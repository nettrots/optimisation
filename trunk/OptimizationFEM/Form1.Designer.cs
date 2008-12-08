namespace OptimizationFEM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPhi2 = new System.Windows.Forms.TextBox();
            this.checkBoxPhi2 = new System.Windows.Forms.CheckBox();
            this.textBoxPhi1 = new System.Windows.Forms.TextBox();
            this.checkBoxPhi1 = new System.Windows.Forms.CheckBox();
            this.textBoxPhi0 = new System.Windows.Forms.TextBox();
            this.checkBoxPhi0 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPhi2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPhi0 = new System.Windows.Forms.RadioButton();
            this.radioButtonPhi1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHstep = new System.Windows.Forms.TextBox();
            this.textBoxHmax = new System.Windows.Forms.TextBox();
            this.textBoxHmin = new System.Windows.Forms.TextBox();
            this.checkBoxH = new System.Windows.Forms.CheckBox();
            this.textBoxNumax = new System.Windows.Forms.TextBox();
            this.textBoxNumin = new System.Windows.Forms.TextBox();
            this.checkBoxNu = new System.Windows.Forms.CheckBox();
            this.textBoxEstep = new System.Windows.Forms.TextBox();
            this.textBoxEmax = new System.Windows.Forms.TextBox();
            this.textBoxEmin = new System.Windows.Forms.TextBox();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxNustep = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhi2
            // 
            this.textBoxPhi2.Location = new System.Drawing.Point(226, 133);
            this.textBoxPhi2.Name = "textBoxPhi2";
            this.textBoxPhi2.Size = new System.Drawing.Size(91, 20);
            this.textBoxPhi2.TabIndex = 8;
            this.textBoxPhi2.Text = "2";
            // 
            // checkBoxPhi2
            // 
            this.checkBoxPhi2.AutoSize = true;
            this.checkBoxPhi2.Checked = true;
            this.checkBoxPhi2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPhi2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPhi2.Location = new System.Drawing.Point(171, 133);
            this.checkBoxPhi2.Name = "checkBoxPhi2";
            this.checkBoxPhi2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPhi2.TabIndex = 6;
            this.checkBoxPhi2.UseVisualStyleBackColor = true;
            this.checkBoxPhi2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBoxPhi1
            // 
            this.textBoxPhi1.Location = new System.Drawing.Point(226, 73);
            this.textBoxPhi1.Name = "textBoxPhi1";
            this.textBoxPhi1.Size = new System.Drawing.Size(91, 20);
            this.textBoxPhi1.TabIndex = 5;
            this.textBoxPhi1.Text = "0.01";
            // 
            // checkBoxPhi1
            // 
            this.checkBoxPhi1.AutoSize = true;
            this.checkBoxPhi1.Checked = true;
            this.checkBoxPhi1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPhi1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPhi1.Location = new System.Drawing.Point(171, 73);
            this.checkBoxPhi1.Name = "checkBoxPhi1";
            this.checkBoxPhi1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPhi1.TabIndex = 3;
            this.checkBoxPhi1.UseVisualStyleBackColor = true;
            this.checkBoxPhi1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBoxPhi0
            // 
            this.textBoxPhi0.Enabled = false;
            this.textBoxPhi0.Location = new System.Drawing.Point(226, 32);
            this.textBoxPhi0.Name = "textBoxPhi0";
            this.textBoxPhi0.Size = new System.Drawing.Size(82, 20);
            this.textBoxPhi0.TabIndex = 2;
            this.textBoxPhi0.Text = "2.5";
            // 
            // checkBoxPhi0
            // 
            this.checkBoxPhi0.AutoSize = true;
            this.checkBoxPhi0.Enabled = false;
            this.checkBoxPhi0.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBoxPhi0.Location = new System.Drawing.Point(171, 32);
            this.checkBoxPhi0.Name = "checkBoxPhi0";
            this.checkBoxPhi0.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPhi0.TabIndex = 0;
            this.checkBoxPhi0.UseVisualStyleBackColor = true;
            this.checkBoxPhi0.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main functional";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhi2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonPhi2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonPhi0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhi1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxPhi2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhi0, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonPhi1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxPhi0, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxPhi1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 204);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Активне";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Обмеження";
            // 
            // radioButtonPhi2
            // 
            this.radioButtonPhi2.AutoSize = true;
            this.radioButtonPhi2.Image = global::OptimizationFEM.Resource1.phi2;
            this.radioButtonPhi2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonPhi2.Location = new System.Drawing.Point(3, 133);
            this.radioButtonPhi2.Name = "radioButtonPhi2";
            this.radioButtonPhi2.Size = new System.Drawing.Size(101, 24);
            this.radioButtonPhi2.TabIndex = 2;
            this.radioButtonPhi2.UseVisualStyleBackColor = true;
            this.radioButtonPhi2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPhi0
            // 
            this.radioButtonPhi0.AutoSize = true;
            this.radioButtonPhi0.Checked = true;
            this.radioButtonPhi0.Image = global::OptimizationFEM.Resource1.phi0;
            this.radioButtonPhi0.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.radioButtonPhi0.Location = new System.Drawing.Point(3, 32);
            this.radioButtonPhi0.Name = "radioButtonPhi0";
            this.radioButtonPhi0.Size = new System.Drawing.Size(88, 35);
            this.radioButtonPhi0.TabIndex = 0;
            this.radioButtonPhi0.TabStop = true;
            this.radioButtonPhi0.UseVisualStyleBackColor = true;
            this.radioButtonPhi0.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPhi1
            // 
            this.radioButtonPhi1.AutoSize = true;
            this.radioButtonPhi1.Image = global::OptimizationFEM.Resource1.phi1;
            this.radioButtonPhi1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonPhi1.Location = new System.Drawing.Point(3, 73);
            this.radioButtonPhi1.Name = "radioButtonPhi1";
            this.radioButtonPhi1.Size = new System.Drawing.Size(89, 24);
            this.radioButtonPhi1.TabIndex = 1;
            this.radioButtonPhi1.UseVisualStyleBackColor = true;
            this.radioButtonPhi1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Функціонал керування";
            // 
            // textBoxHstep
            // 
            this.textBoxHstep.Location = new System.Drawing.Point(88, 190);
            this.textBoxHstep.Name = "textBoxHstep";
            this.textBoxHstep.Size = new System.Drawing.Size(62, 20);
            this.textBoxHstep.TabIndex = 17;
            this.textBoxHstep.Text = "0.1";
            // 
            // textBoxHmax
            // 
            this.textBoxHmax.Location = new System.Drawing.Point(88, 32);
            this.textBoxHmax.Name = "textBoxHmax";
            this.textBoxHmax.Size = new System.Drawing.Size(62, 20);
            this.textBoxHmax.TabIndex = 15;
            this.textBoxHmax.Text = "0.9";
            // 
            // textBoxHmin
            // 
            this.textBoxHmin.Location = new System.Drawing.Point(88, 164);
            this.textBoxHmin.Name = "textBoxHmin";
            this.textBoxHmin.Size = new System.Drawing.Size(62, 20);
            this.textBoxHmin.TabIndex = 14;
            this.textBoxHmin.Text = "0.1";
            // 
            // checkBoxH
            // 
            this.checkBoxH.AutoSize = true;
            this.checkBoxH.Checked = true;
            this.checkBoxH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxH.Location = new System.Drawing.Point(88, 16);
            this.checkBoxH.Name = "checkBoxH";
            this.checkBoxH.Size = new System.Drawing.Size(35, 17);
            this.checkBoxH.TabIndex = 13;
            this.checkBoxH.Text = "L:";
            this.checkBoxH.UseVisualStyleBackColor = true;
            // 
            // textBoxNumax
            // 
            this.textBoxNumax.Location = new System.Drawing.Point(242, 164);
            this.textBoxNumax.Name = "textBoxNumax";
            this.textBoxNumax.Size = new System.Drawing.Size(62, 20);
            this.textBoxNumax.TabIndex = 10;
            this.textBoxNumax.Text = "0.4";
            // 
            // textBoxNumin
            // 
            this.textBoxNumin.Location = new System.Drawing.Point(242, 32);
            this.textBoxNumin.Name = "textBoxNumin";
            this.textBoxNumin.Size = new System.Drawing.Size(62, 20);
            this.textBoxNumin.TabIndex = 9;
            this.textBoxNumin.Text = "0.2";
            // 
            // checkBoxNu
            // 
            this.checkBoxNu.AutoSize = true;
            this.checkBoxNu.Checked = true;
            this.checkBoxNu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNu.Location = new System.Drawing.Point(245, 16);
            this.checkBoxNu.Name = "checkBoxNu";
            this.checkBoxNu.Size = new System.Drawing.Size(35, 17);
            this.checkBoxNu.TabIndex = 8;
            this.checkBoxNu.Text = "ν:";
            this.checkBoxNu.UseVisualStyleBackColor = true;
            // 
            // textBoxEstep
            // 
            this.textBoxEstep.Location = new System.Drawing.Point(168, 190);
            this.textBoxEstep.Name = "textBoxEstep";
            this.textBoxEstep.Size = new System.Drawing.Size(62, 20);
            this.textBoxEstep.TabIndex = 7;
            this.textBoxEstep.Text = "2500";
            // 
            // textBoxEmax
            // 
            this.textBoxEmax.Location = new System.Drawing.Point(168, 164);
            this.textBoxEmax.Name = "textBoxEmax";
            this.textBoxEmax.Size = new System.Drawing.Size(62, 20);
            this.textBoxEmax.TabIndex = 5;
            this.textBoxEmax.Text = "25000";
            // 
            // textBoxEmin
            // 
            this.textBoxEmin.Location = new System.Drawing.Point(163, 32);
            this.textBoxEmin.Name = "textBoxEmin";
            this.textBoxEmin.Size = new System.Drawing.Size(62, 20);
            this.textBoxEmin.TabIndex = 1;
            this.textBoxEmin.Text = "20000";
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Checked = true;
            this.checkBoxE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxE.Location = new System.Drawing.Point(168, 16);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(35, 17);
            this.checkBoxE.TabIndex = 0;
            this.checkBoxE.Text = "Ε:";
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 246);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(12, 264);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(209, 222);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Optimization";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Крок";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(88, 58);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 100);
            this.trackBar1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Максимальне";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(168, 58);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 100);
            this.trackBar2.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Мінімальне";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(245, 58);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 100);
            this.trackBar3.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Controls.Add(this.textBoxHstep);
            this.groupBox4.Controls.Add(this.textBoxHmax);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.trackBar2);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBoxHmin);
            this.groupBox4.Controls.Add(this.checkBoxH);
            this.groupBox4.Controls.Add(this.textBoxNustep);
            this.groupBox4.Controls.Add(this.trackBar3);
            this.groupBox4.Controls.Add(this.textBoxEstep);
            this.groupBox4.Controls.Add(this.textBoxNumin);
            this.groupBox4.Controls.Add(this.textBoxNumax);
            this.groupBox4.Controls.Add(this.checkBoxNu);
            this.groupBox4.Controls.Add(this.textBoxEmax);
            this.groupBox4.Controls.Add(this.textBoxEmin);
            this.groupBox4.Controls.Add(this.checkBoxE);
            this.groupBox4.Location = new System.Drawing.Point(576, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 234);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox1";
            // 
            // textBoxNustep
            // 
            this.textBoxNustep.Location = new System.Drawing.Point(242, 190);
            this.textBoxNustep.Name = "textBoxNustep";
            this.textBoxNustep.Size = new System.Drawing.Size(62, 20);
            this.textBoxNustep.TabIndex = 12;
            this.textBoxNustep.Text = "0.1";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dg.Location = new System.Drawing.Point(248, 280);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Size = new System.Drawing.Size(240, 150);
            this.dg.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(949, 663);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtb);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Optimization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxEmin;
        private System.Windows.Forms.CheckBox checkBoxE;
        private System.Windows.Forms.TextBox textBoxEmax;
        private System.Windows.Forms.TextBox textBoxHstep;
        private System.Windows.Forms.TextBox textBoxHmax;
        private System.Windows.Forms.TextBox textBoxHmin;
        private System.Windows.Forms.CheckBox checkBoxH;
        private System.Windows.Forms.TextBox textBoxNumax;
        private System.Windows.Forms.TextBox textBoxNumin;
        private System.Windows.Forms.CheckBox checkBoxNu;
        private System.Windows.Forms.TextBox textBoxEstep;
        private System.Windows.Forms.RadioButton radioButtonPhi2;
        private System.Windows.Forms.RadioButton radioButtonPhi1;
        private System.Windows.Forms.RadioButton radioButtonPhi0;
        private System.Windows.Forms.CheckBox checkBoxPhi0;
        private System.Windows.Forms.TextBox textBoxPhi0;
        private System.Windows.Forms.TextBox textBoxPhi2;
        private System.Windows.Forms.CheckBox checkBoxPhi2;
        private System.Windows.Forms.TextBox textBoxPhi1;
        private System.Windows.Forms.CheckBox checkBoxPhi1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxNustep;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

