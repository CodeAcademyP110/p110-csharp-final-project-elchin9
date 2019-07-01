namespace FitnessForm
{
    partial class AddPacketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPacketsForm));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nmrService = new System.Windows.Forms.NumericUpDown();
            this.btnAddPackets = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.jk = new System.Windows.Forms.Label();
            this.chcGYM = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chcSauna = new System.Windows.Forms.CheckBox();
            this.chcPool = new System.Windows.Forms.CheckBox();
            this.chcMassage = new System.Windows.Forms.CheckBox();
            this.gradientPanel1 = new FitnessForm.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrService)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(276, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // nmrService
            // 
            this.nmrService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrService.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nmrService.Location = new System.Drawing.Point(18, 205);
            this.nmrService.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nmrService.Name = "nmrService";
            this.nmrService.Size = new System.Drawing.Size(277, 29);
            this.nmrService.TabIndex = 44;
            // 
            // btnAddPackets
            // 
            this.btnAddPackets.BackColor = System.Drawing.Color.Purple;
            this.btnAddPackets.FlatAppearance.BorderSize = 0;
            this.btnAddPackets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPackets.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPackets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPackets.Location = new System.Drawing.Point(18, 526);
            this.btnAddPackets.Name = "btnAddPackets";
            this.btnAddPackets.Size = new System.Drawing.Size(277, 47);
            this.btnAddPackets.TabIndex = 43;
            this.btnAddPackets.Text = "Add";
            this.btnAddPackets.UseVisualStyleBackColor = false;
            this.btnAddPackets.Click += new System.EventHandler(this.btnAddNewService_Click);
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(18, 287);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(277, 32);
            this.txtDays.TabIndex = 42;
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Days.Location = new System.Drawing.Point(14, 261);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(50, 23);
            this.Days.TabIndex = 41;
            this.Days.Text = "Days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(18, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 32);
            this.txtName.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "Add New Packets";
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(18, 362);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(277, 32);
            this.txtHours.TabIndex = 47;
            // 
            // jk
            // 
            this.jk.AutoSize = true;
            this.jk.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jk.Location = new System.Drawing.Point(14, 336);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(60, 23);
            this.jk.TabIndex = 46;
            this.jk.Text = "Hours";
            // 
            // chcGYM
            // 
            this.chcGYM.AutoSize = true;
            this.chcGYM.BackColor = System.Drawing.Color.Transparent;
            this.chcGYM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcGYM.Location = new System.Drawing.Point(18, 451);
            this.chcGYM.Name = "chcGYM";
            this.chcGYM.Size = new System.Drawing.Size(57, 20);
            this.chcGYM.TabIndex = 48;
            this.chcGYM.Text = "GYM";
            this.chcGYM.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Services";
            // 
            // chcSauna
            // 
            this.chcSauna.AutoSize = true;
            this.chcSauna.BackColor = System.Drawing.Color.Transparent;
            this.chcSauna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcSauna.Location = new System.Drawing.Point(18, 479);
            this.chcSauna.Name = "chcSauna";
            this.chcSauna.Size = new System.Drawing.Size(66, 20);
            this.chcSauna.TabIndex = 50;
            this.chcSauna.Text = "Sauna";
            this.chcSauna.UseVisualStyleBackColor = false;
            // 
            // chcPool
            // 
            this.chcPool.AutoSize = true;
            this.chcPool.BackColor = System.Drawing.Color.Transparent;
            this.chcPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcPool.Location = new System.Drawing.Point(157, 451);
            this.chcPool.Name = "chcPool";
            this.chcPool.Size = new System.Drawing.Size(55, 20);
            this.chcPool.TabIndex = 51;
            this.chcPool.Text = "Pool";
            this.chcPool.UseVisualStyleBackColor = false;
            // 
            // chcMassage
            // 
            this.chcMassage.AutoSize = true;
            this.chcMassage.BackColor = System.Drawing.Color.Transparent;
            this.chcMassage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcMassage.Location = new System.Drawing.Point(157, 479);
            this.chcMassage.Name = "chcMassage";
            this.chcMassage.Size = new System.Drawing.Size(84, 20);
            this.chcMassage.TabIndex = 52;
            this.chcMassage.Text = "Massage";
            this.chcMassage.UseVisualStyleBackColor = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.DeepSkyBlue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Purple;
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.chcMassage);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.chcPool);
            this.gradientPanel1.Controls.Add(this.txtName);
            this.gradientPanel1.Controls.Add(this.chcSauna);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.chcGYM);
            this.gradientPanel1.Controls.Add(this.Days);
            this.gradientPanel1.Controls.Add(this.txtHours);
            this.gradientPanel1.Controls.Add(this.txtDays);
            this.gradientPanel1.Controls.Add(this.jk);
            this.gradientPanel1.Controls.Add(this.btnAddPackets);
            this.gradientPanel1.Controls.Add(this.nmrService);
            this.gradientPanel1.Location = new System.Drawing.Point(-1, -7);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(319, 588);
            this.gradientPanel1.TabIndex = 53;
            // 
            // AddPacketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(309, 581);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPacketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPacketsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrService)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown nmrService;
        private System.Windows.Forms.Button btnAddPackets;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label jk;
        private System.Windows.Forms.CheckBox chcGYM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chcSauna;
        private System.Windows.Forms.CheckBox chcPool;
        private System.Windows.Forms.CheckBox chcMassage;
        private GradientPanel gradientPanel1;
    }
}