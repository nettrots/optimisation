﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SbBMortar.SbB;

namespace OptimizationFEM
{
    internal delegate double functional(double E, double Nu, double h);
    internal delegate void Writer(Font font, Color color, string s);
    internal delegate void Work(functional[] limited);
    
    public partial class Form1 : Form
    {
        #region Fileds

        private string points;
        private double minE, maxE, minNu, maxNu, minH, maxH, rho, stepE, stepNu, stepH;
        private double phi1plus, phi2plus;
        private double rezE = 0, rezNu = 0, rezH = 0;

        private Domain domain;

        private functional phi0, phi1, phi2;

        Font[] fonts = new Font[] { new Font("Microsoft Sans Serif", 10), 
                                    new Font("Microsoft Sans Serif", 8),
                                    new Font("Microsoft Sans Serif", 8),
                                    new Font("Microsoft Sans Serif", 8),
                                  };
        Color[] colors = new Color[]
                                  { Color.Red,
                                    Color.Black,
                                    Color.Blue,
                                    Color.Brown
                                  };
        #endregion


        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        private int c = 0;
        void AddText(Font font, Color color, string text)
        {
            rtb.SelectionFont = font;
            rtb.SelectionColor = color;
            rtb.SelectedText += text;
            if (text.Contains("Point"))
            {
                string[] strs = text.Split(' ');
                for (int i=0; i < strs.Length;i++ )
                {
                    if (strs[i].Contains("=")) strs[i] = strs[i].Substring(2, strs[i].Length - 3);
                }
                dg.Rows.Add(c++, strs[4], strs[8], strs[12]);
            }
            else
            {
                
            }
           
        }
       
        #region Help functions
        Domain Problem(double E, double Nu, double h)
        {
            StreamWriter sw = new StreamWriter("temp.txt");
            string s;
            bool t1 = h > 0;
            bool t2 = h < 0.9;
            if (t1)
            {
                if (t2)
                {
                    sw.WriteLine(12);
                    s =
                        string.Format(
                            "0.75 -0.5 -0.75 -0.5 -0.75 {0} -1 {1} -1 {2} -0.75 {3} -0.75 0.5 0.75 0.5 0.75 {4} 1 {5} 1 {6} 0.75 {7}",
                            (-0.5 + h), (-0.5 + h), (-0.5 + h + 0.1), (-0.5 + h + 0.1), (-0.5 + h + 0.1),
                            (-0.5 + h + 0.1), (-0.5 + h), (-0.5 + h));
                    s=s.Replace(",", ".");
                    sw.WriteLine(s);
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Static 0 0");//!
                    sw.WriteLine("Kinematic");//!
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Static 0 -1");
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Kinematic");//!
                    sw.WriteLine("Static 0 0");//!
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Kinematic");
                    sw.WriteLine(1);
                    sw.WriteLine(12);
                    sw.WriteLine(s);
                }

                else
                {
                    sw.WriteLine(10);
                    s = string.Format("0.75 -0.5 -0.75 -0.5 -0.75 {0} -1 {1} -1 {2} -0.75 {3} 0.75 {4} 1 {5} 1 {6} 0.75 {7}", (-0.5 + h), (-0.5 + h), (-0.5 + h + 0.1), (-0.5 + h + 0.1), (-0.5 + h + 0.1), (-0.5 + h + 0.1), (-0.5 + h), (-0.5 + h));
                    s = s.Replace(",", ".");
                    sw.WriteLine(s);
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Static 0 0");//!
                    sw.WriteLine("Kinematic");//!
                    sw.WriteLine("Static 0 -1");
                    sw.WriteLine("Kinematic");//!
                    sw.WriteLine("Static 0 0");//!
                    sw.WriteLine("Kinematic");
                    sw.WriteLine("Kinematic");
                    sw.WriteLine(1);
                    sw.WriteLine(10);
                    sw.WriteLine(s);

                }
            }
            else
            {
                sw.WriteLine(10);
                s =
                    string.Format(
                        "-0.75 {0} -1 {1} -1 {2} -0.75 {3} -0.75 0.5 0.75 0.5 0.75 {4} 1 {5} 1 {6} 0.75 {7}",
                        (-0.5 + h), (-0.5 + h), (-0.5 + h + 0.1), (-0.5 + h + 0.1), (-0.5 + h + 0.1), (-0.5 + h + 0.1),
                        (-0.5 + h), (-0.5 + h));
                s = s.Replace(",", ".");
                sw.WriteLine(s);
                sw.WriteLine("Kinematic");
                sw.WriteLine("Static 0 0");//!
                sw.WriteLine("Kinematic");//!
                sw.WriteLine("Kinematic");
                sw.WriteLine("Static 0 -100");
                sw.WriteLine("Kinematic");
                sw.WriteLine("Kinematic");//!
                sw.WriteLine("Static 0 0");//!
                sw.WriteLine("Kinematic");
                sw.WriteLine("Kinematic");
                sw.WriteLine(1);
                sw.WriteLine(10);
                sw.WriteLine(s);
            }
            
            sw.WriteLine("{0} {1}", E, Nu);
            sw.WriteLine("LinearTriangle {0} 20", 0.1/4);
            sw.WriteLine(0);
            sw.Close();
            Domain domain = new Domain("temp.txt");
            domain.mesh();
            domain.solve();
            points = s;
            return domain;
        }

        double Phi0(double E, double Nu, double h)
        {
            GaussianQuadrature interg=new GaussianQuadrature(U0);
            return 1*interg.defineIntegral(-1, 1)/2; ;
        }
        double U0(double t)
        {
            return domain.U(t, 0.5);
        }
        double Phi1(double E, double Nu, double h)
        {
            double max = double.NegativeInfinity;
            //Domain domain = Problem(E, Nu, h);
            for (int i = 0; i < domain.Vertexes.Count; i++)
            {
                Vector x = new Vector(2);
                x[0] = domain.U(i);
                x[1] = domain.V(i);
                double rez = x.norm();
                if (max<rez) max = rez;
            }
            return max;
        }
        double Phi2(double E, double Nu, double h)
        {
            double max = double.NegativeInfinity;
            //Domain domain = Problem(E, Nu, h);
            for (int i = 0; i < domain.Vertexes.Count; i++)
            {
                double rez = Math.Abs(domain.Sxx(i));
                if (max<rez) max = rez;
            }
            return max;
        }


        void Preprocess()
        {
            minE = maxE = 21000;
            minNu = maxNu = 0.3;
            minH = maxH = 1;
            stepE = stepH = stepNu = 1;

            if (!checkBoxE.Checked && !checkBoxNu.Checked && !checkBoxH.Checked)
                throw new Exception("Please, choose at least one parameter!!!");
            
            if (checkBoxE.Checked)
            {
                minE = double.Parse(textBoxEmin.Text);
                maxE = double.Parse(textBoxEmax.Text);
                stepE = double.Parse(textBoxEstep.Text);
            }
            if (checkBoxNu.Checked)
            {
                minNu = double.Parse(textBoxNumin.Text);
                maxNu = double.Parse(textBoxNumax.Text);
                stepNu = double.Parse(textBoxNustep.Text);
            }
            if (checkBoxH.Checked)
            {
                minH = double.Parse(textBoxHmin.Text);
                maxH = double.Parse(textBoxHmax.Text);
                stepH = double.Parse(textBoxHstep.Text);
            }
            //rho = double.Parse(textBoxRo.Text);


            phi0 = phi1 = phi2 = null;
            phi0 = radioButtonPhi0.Checked ? Phi0 : phi0;
            phi0 = radioButtonPhi1.Checked ? Phi1 : phi0;
            phi0 = radioButtonPhi2.Checked ? Phi2 : phi0;

            if (checkBoxPhi0.Checked)
                if (phi1 == null)
                {
                    phi1 = Phi0;
                    phi1plus = double.Parse(textBoxPhi0.Text);
                }
                else
                {
                    phi2 = Phi0;
                    phi2plus = double.Parse(textBoxPhi0.Text);
                }
            if (checkBoxPhi1.Checked)
                if (phi1 == null)
                {
                    phi1 = Phi1; 
                    phi1plus = double.Parse(textBoxPhi1.Text);
                }
                else
                {
                    phi2 = Phi1;
                    phi2plus = double.Parse(textBoxPhi1.Text);
                }
            if (checkBoxPhi2.Checked)
                if (phi1 == null)
                {
                    phi1 = Phi2;
                    phi1plus = double.Parse(textBoxPhi2.Text);
                }
                else
                {
                    phi2 = Phi2;
                    phi2plus = double.Parse(textBoxPhi2.Text);
                }
        }
        void Process(functional[] limited)
        {
            Writer writer = AddText;
          
            rezE = 0;
            double optiE, optiNu, optiH, optiPhi0, optiPhi1, optiPhi2;
            optiE = optiNu = optiH = optiPhi1 = optiPhi2 = 0;
            optiPhi0 = double.PositiveInfinity;
            double[] phiplus = new double[] {phi1plus, phi2plus};
            for (double E = minE; E<=maxE; E+=stepE)
                for(double Nu = minNu; Nu<=maxNu; Nu+=stepNu)
                    for (double h = minH; h<=maxH; h+=stepH)
                    {
                        domain = Problem(E, Nu, h);
                        this.BeginInvoke(writer, fonts[0], colors[0], string.Format("Point:    Ε={0},    ν={1},    h={2}\n", E, Nu, h));
                        double currentphi0 = phi0(E, Nu, h);
                        this.BeginInvoke(writer, fonts[1], colors[1], string.Format("ψ0 = {0}\n", currentphi0));
                        double[] currentlimited = new double[limited.Length];
                        bool t = true;
                       
                        for (int i = 0; i < limited.Length; i++)
                        {
                            currentlimited[i] = limited[i](E, Nu, h);
                            this.BeginInvoke(writer, fonts[1], colors[1], string.Format("ψ{2} = {0} ≤ {1}\t\t", currentlimited[i].ToString("e8"), phiplus[i], i + 1));
                           
                            if (currentlimited[i]>=phiplus[i])
                            {
                                t = false;
                                this.BeginInvoke(writer, fonts[3], colors[3], "FALSE\n");
                            }
                            else this.BeginInvoke(writer, fonts[2], colors[2], "TRUE\n");
                        }
                        this.BeginInvoke(writer, fonts[0], colors[0], "\n");
                        
                        if (currentphi0 > optiPhi0) continue;
                        if (!t) continue;
                        optiE = E;
                        optiNu = Nu;
                        optiH = h;
                        optiPhi0 = currentphi0;
                        if (currentlimited.Length >= 1) optiPhi1 = currentlimited[0];
                        if (currentlimited.Length >= 2) optiPhi2 = currentlimited[1]; 
                    }
            if (optiE==0)
            {
                this.BeginInvoke(writer, fonts[0], colors[0], "Optimization is failed!!! :(");
                MessageBox.Show("Done!!!", "Optimization");
                return;
            }
            this.BeginInvoke(writer, fonts[0], colors[0], "Optimization gives next results:\n");
            this.BeginInvoke(writer, fonts[1], colors[1], string.Format("Ε = {0}\n", optiE));
            this.BeginInvoke(writer, fonts[1], colors[1], string.Format("ν = {0}\n", optiNu));
            this.BeginInvoke(writer, fonts[1], colors[1], string.Format("h = {0}\n", optiH));
            this.BeginInvoke(writer, fonts[1], colors[1], string.Format("ψ0 = {0}\n", optiPhi0));
            int count = 1;
            if (limited.Length >= 1) this.BeginInvoke(writer, fonts[1], colors[1], string.Format("ψ{1} = {0}\n", optiPhi1, count++));
            if (limited.Length >= 2) this.BeginInvoke(writer, fonts[1], colors[1], string.Format("ψ{1} = {0}\n", optiPhi2, count++));
            rezE = optiE;
            rezNu = optiNu;
            rezH = optiH;
            panel3.Invalidate();
            MessageBox.Show("Done!!!", "Optimization");
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Work work = Process;
            try
            {
                rtb.Text = "";
                Preprocess();
                int count = 0;
                if (phi1 != null) count++;
                if (phi2 != null) count++;
                functional[] limited = new functional[count];
                count = 0;
                if (phi1 != null) limited[count++] = phi1;
                if (phi2 != null) limited[count++] = phi2;
                work.BeginInvoke(limited, null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fatal error");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            double h = rezH;
            string s =
                        string.Format(
                            "0.75 -0.5 -0.75 -0.5 -0.75 {0} -1 {1} -1 {2} -0.75 {3} -0.75 0.5 0.75 0.5 0.75 {4} 1 {5} 1 {6} 0.75 {7}",
                            (-0.5 + h), (-0.5 + h), (-0.5 + h + 0.1), (-0.5 + h + 0.1), (-0.5 + h + 0.1),
                            (-0.5 + h + 0.1), (-0.5 + h), (-0.5 + h));
            string[] d = s.Split(' ');
            float[] xx = new float[d.Length/2];
            float[] yy = new float[d.Length / 2];
            PointF[] pxy = new PointF[d.Length/2];
            for (int i = 0; i < d.Length/2; i++)
            {
                xx[i] = float.Parse(d[2 * i])*100+150;
                yy[i] = 110-float.Parse(d[2 * i + 1]) * 100;
                pxy[i] = new PointF(xx[i], yy[i]);
            }


            Graphics g = e.Graphics;
            g.DrawPolygon(Pens.Black, pxy);
            //g.DrawPolygon(Pens.Black, new Point[]{new Point(70,40), new Point(70,140), new Point(270,140), new Point(270,40)});
            //for (int i = 0; i < 5; i++)
            //{
            //    g.DrawLine(Pens.Black, 50, 60 + i*20, 70, 40 + i*20);
            //    g.DrawLine(Pens.Black, 70, 60 + i * 20, 50, 40 + i * 20);
            //}
            Pen pen = new Pen(Color.Black);
            pen.EndCap = LineCap.ArrowAnchor;
            for (int i = 0; i < 8; i++)
            {
                g.DrawLine(pen, 75 + i * 21, 33, 75 + i * 21, 55);
            }
            g.DrawString("p = (0,-1)", this.Font, Brushes.Red, 120, 10);
            if (rezE==0)
            {
                g.DrawString("Ε", this.Font, Brushes.Blue, 160, 65);
                g.DrawString("ν", this.Font, Brushes.Blue, 160, 85);

                pen.StartCap = LineCap.ArrowAnchor;
                pen.Color = Color.Blue;
                g.DrawLine(pen, 280, 40, 280, 140);
                g.DrawString("h", this.Font, Brushes.Blue, 290, 80);
            }
            else
            {
                g.DrawString(string.Format("Ε = {0}", rezE), this.Font, Brushes.Blue, 160, 65);
                g.DrawString(string.Format("ν = {0}", rezNu), this.Font, Brushes.Blue, 160, 85);

                pen.StartCap = LineCap.ArrowAnchor;
                pen.Color = Color.Blue;
                g.DrawLine(pen, 280, 40, 280, 140);
                g.DrawString(string.Format("h = {0}", rezH), this.Font, Brushes.Blue, 290, 80);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = sender as RadioButton;
            checkBoxPhi0.Checked = true;
            checkBoxPhi1.Checked = true; 
            checkBoxPhi2.Checked = true;
            checkBoxPhi0.Enabled = true;
            checkBoxPhi1.Enabled = true;
            checkBoxPhi2.Enabled = true;
            textBoxPhi0.Enabled = true;
            textBoxPhi1.Enabled = true;
            textBoxPhi2.Enabled = true;
            if (rb==radioButtonPhi0)
            {
                checkBoxPhi0.Checked = false;
                checkBoxPhi0.Enabled = false;
                textBoxPhi0.Enabled = false;
            }
            if (rb == radioButtonPhi1)
            {
                checkBoxPhi1.Checked = false;
                checkBoxPhi1.Enabled = false;
                textBoxPhi1.Enabled = false;
            }
            if (rb == radioButtonPhi2)
            {
                checkBoxPhi2.Checked = false;
                checkBoxPhi2.Enabled = false;
                textBoxPhi2.Enabled = false;
            }
            rtb.Text = "";
            rezE = 0;
            panel3.Invalidate();
        }

        private void checkBoxPhi0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            rtb.Text = "";
            rezE = 0;
            panel3.Invalidate();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
