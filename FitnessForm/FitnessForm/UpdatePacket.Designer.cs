namespace FitnessForm
{
    partial class UpdatePacket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePacket));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlUpdateInner = new System.Windows.Forms.Panel();
            this.txtUpdateHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrUpdatePrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateDays = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPackets = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new FitnessForm.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlUpdateInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpdatePrice)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(290, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pnlUpdateInner
            // 
            this.pnlUpdateInner.Controls.Add(this.txtUpdateHours);
            this.pnlUpdateInner.Controls.Add(this.label1);
            this.pnlUpdateInner.Controls.Add(this.nmrUpdatePrice);
            this.pnlUpdateInner.Controls.Add(this.btnUpdate);
            this.pnlUpdateInner.Controls.Add(this.label11);
            this.pnlUpdateInner.Controls.Add(this.txtUpdateDays);
            this.pnlUpdateInner.Controls.Add(this.txtUpdateName);
            this.pnlUpdateInner.Controls.Add(this.label9);
            this.pnlUpdateInner.Controls.Add(this.label10);
            this.pnlUpdateInner.Location = new System.Drawing.Point(-7, 162);
            this.pnlUpdateInner.Name = "pnlUpdateInner";
            this.pnlUpdateInner.Size = new System.Drawing.Size(345, 375);
            this.pnlUpdateInner.TabIndex = 41;
            this.pnlUpdateInner.Visible = false;
            // 
            // txtUpdateHours
            // 
            this.txtUpdateHours.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateHours.Location = new System.Drawing.Point(31, 259);
            this.txtUpdateHours.Name = "txtUpdateHours";
            this.txtUpdateHours.Size = new System.Drawing.Size(277, 32);
            this.txtUpdateHours.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hours";
            // 
            // nmrUpdatePrice
            // 
            this.nmrUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrUpdatePrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nmrUpdatePrice.Location = new System.Drawing.Point(32, 113);
            this.nmrUpdatePrice.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nmrUpdatePrice.Name = "nmrUpdatePrice";
            this.nmrUpdatePrice.Size = new System.Drawing.Size(277, 29);
            this.nmrUpdatePrice.TabIndex = 29;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Purple;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(32, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(277, 47);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Name";
            // 
            // txtUpdateDays
            // 
            this.txtUpdateDays.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateDays.Location = new System.Drawing.Point(31, 188);
            this.txtUpdateDays.Name = "txtUpdateDays";
            this.txtUpdateDays.Size = new System.Drawing.Size(277, 32);
            this.txtUpdateDays.TabIndex = 27;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateName.Location = new System.Drawing.Point(29, 39);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(277, 32);
            this.txtUpdateName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "Days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 23);
            this.label12.TabIndex = 40;
            this.label12.Text = "Select Packet";
            // 
            // cmbPackets
            // 
            this.cmbPackets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackets.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPackets.FormattingEnabled = true;
            this.cmbPackets.Location = new System.Drawing.Point(25, 111);
            this.cmbPackets.Name = "cmbPackets";
            this.cmbPackets.Size = new System.Drawing.Size(276, 31);
            this.cmbPackets.TabIndex = 39;
            this.cmbPackets.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 27);
            this.label8.TabIndex = 38;
            this.label8.Text = "Update Packet";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.DeepSkyBlue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Purple;
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.pnlUpdateInner);
            this.gradientPanel1.Controls.Add(this.cmbPackets);
            this.gradientPanel1.Controls.Add(this.label12);
            this.gradientPanel1.Location = new System.Drawing.Point(-1, -1);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(403, 543);
            this.gradientPanel1.TabIndex = 43;
            // 
            // UpdatePacket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(324, 543);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePacket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePacket";
            this.Load += new System.EventHandler(this.UpdatePacket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlUpdateInner.ResumeLayout(false);
            this.pnlUpdateInner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpdatePrice)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlUpdateInner;
        private System.Windows.Forms.NumericUpDown nmrUpdatePrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbPackets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateDays;
        private System.Windows.Forms.Label label9;
        private GradientPanel gradientPanel1;
    }
}