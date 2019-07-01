namespace FitnessForm
{
    partial class RevenueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueForm));
            this.pnlFinance = new System.Windows.Forms.Panel();
            this.pnlNet = new System.Windows.Forms.Panel();
            this.nmrcNet = new System.Windows.Forms.NumericUpDown();
            this.nmrcRevenue = new System.Windows.Forms.NumericUpDown();
            this.nmrcExpenses = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dgwFInance = new System.Windows.Forms.DataGridView();
            this.lblDgwHeading = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new FitnessForm.GradientPanel();
            this.pnlFinance.SuspendLayout();
            this.pnlNet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFInance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFinance
            // 
            this.pnlFinance.BackColor = System.Drawing.Color.Transparent;
            this.pnlFinance.Controls.Add(this.pnlNet);
            this.pnlFinance.Controls.Add(this.pictureBox3);
            this.pnlFinance.Controls.Add(this.dgwFInance);
            this.pnlFinance.Controls.Add(this.lblDgwHeading);
            this.pnlFinance.Controls.Add(this.label9);
            this.pnlFinance.Controls.Add(this.label10);
            this.pnlFinance.Controls.Add(this.label11);
            this.pnlFinance.Controls.Add(this.pictureBox11);
            this.pnlFinance.Controls.Add(this.pictureBox12);
            this.pnlFinance.Controls.Add(this.pictureBox13);
            this.pnlFinance.Location = new System.Drawing.Point(15, 0);
            this.pnlFinance.Name = "pnlFinance";
            this.pnlFinance.Size = new System.Drawing.Size(653, 571);
            this.pnlFinance.TabIndex = 23;
            this.pnlFinance.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFinance_Paint);
            // 
            // pnlNet
            // 
            this.pnlNet.BackColor = System.Drawing.Color.Teal;
            this.pnlNet.Controls.Add(this.nmrcNet);
            this.pnlNet.Controls.Add(this.nmrcRevenue);
            this.pnlNet.Controls.Add(this.nmrcExpenses);
            this.pnlNet.Controls.Add(this.label3);
            this.pnlNet.Controls.Add(this.label2);
            this.pnlNet.Controls.Add(this.label1);
            this.pnlNet.Location = new System.Drawing.Point(60, 211);
            this.pnlNet.Name = "pnlNet";
            this.pnlNet.Size = new System.Drawing.Size(515, 267);
            this.pnlNet.TabIndex = 38;
            this.pnlNet.Visible = false;
            // 
            // nmrcNet
            // 
            this.nmrcNet.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcNet.Location = new System.Drawing.Point(118, 209);
            this.nmrcNet.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nmrcNet.Name = "nmrcNet";
            this.nmrcNet.ReadOnly = true;
            this.nmrcNet.Size = new System.Drawing.Size(285, 32);
            this.nmrcNet.TabIndex = 47;
            // 
            // nmrcRevenue
            // 
            this.nmrcRevenue.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcRevenue.Location = new System.Drawing.Point(118, 44);
            this.nmrcRevenue.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nmrcRevenue.Name = "nmrcRevenue";
            this.nmrcRevenue.ReadOnly = true;
            this.nmrcRevenue.Size = new System.Drawing.Size(285, 32);
            this.nmrcRevenue.TabIndex = 46;
            // 
            // nmrcExpenses
            // 
            this.nmrcExpenses.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcExpenses.Location = new System.Drawing.Point(118, 116);
            this.nmrcExpenses.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nmrcExpenses.Name = "nmrcExpenses";
            this.nmrcExpenses.ReadOnly = true;
            this.nmrcExpenses.Size = new System.Drawing.Size(285, 32);
            this.nmrcExpenses.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(114, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Net Revenue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(117, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Expenses Sum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(114, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Revenues Sum";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(617, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dgwFInance
            // 
            this.dgwFInance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFInance.BackgroundColor = System.Drawing.Color.Teal;
            this.dgwFInance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFInance.Location = new System.Drawing.Point(18, 178);
            this.dgwFInance.Name = "dgwFInance";
            this.dgwFInance.Size = new System.Drawing.Size(601, 351);
            this.dgwFInance.TabIndex = 22;
            // 
            // lblDgwHeading
            // 
            this.lblDgwHeading.AutoSize = true;
            this.lblDgwHeading.BackColor = System.Drawing.Color.Teal;
            this.lblDgwHeading.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgwHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDgwHeading.Location = new System.Drawing.Point(259, 143);
            this.lblDgwHeading.Name = "lblDgwHeading";
            this.lblDgwHeading.Size = new System.Drawing.Size(105, 27);
            this.lblDgwHeading.TabIndex = 21;
            this.lblDgwHeading.Text = "Revenues";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(448, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Net Revenue";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(268, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Expenses";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(63, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Revenues";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(472, 5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(66, 86);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(272, 5);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(66, 86);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(74, 3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(66, 86);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 15;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.DeepSkyBlue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Purple;
            this.gradientPanel1.Controls.Add(this.pnlFinance);
            this.gradientPanel1.Location = new System.Drawing.Point(-2, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(670, 571);
            this.gradientPanel1.TabIndex = 24;
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(666, 644);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevenueForm";
            this.pnlFinance.ResumeLayout(false);
            this.pnlFinance.PerformLayout();
            this.pnlNet.ResumeLayout(false);
            this.pnlNet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFInance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFinance;
        private System.Windows.Forms.DataGridView dgwFInance;
        private System.Windows.Forms.Label lblDgwHeading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlNet;
        private System.Windows.Forms.NumericUpDown nmrcNet;
        private System.Windows.Forms.NumericUpDown nmrcRevenue;
        private System.Windows.Forms.NumericUpDown nmrcExpenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GradientPanel gradientPanel1;
    }
}