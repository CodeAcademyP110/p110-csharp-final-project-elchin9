﻿namespace FitnessForm
{
    partial class DeletePackets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePackets));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDeletePacket = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbDeletePackets = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new FitnessForm.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(278, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnDeletePacket
            // 
            this.btnDeletePacket.BackColor = System.Drawing.Color.Purple;
            this.btnDeletePacket.FlatAppearance.BorderSize = 0;
            this.btnDeletePacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePacket.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePacket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletePacket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePacket.Location = new System.Drawing.Point(18, 254);
            this.btnDeletePacket.Name = "btnDeletePacket";
            this.btnDeletePacket.Size = new System.Drawing.Size(277, 47);
            this.btnDeletePacket.TabIndex = 40;
            this.btnDeletePacket.Text = "Delete";
            this.btnDeletePacket.UseVisualStyleBackColor = false;
            this.btnDeletePacket.Visible = false;
            this.btnDeletePacket.Click += new System.EventHandler(this.btnDeletePacket_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 23);
            this.label15.TabIndex = 39;
            this.label15.Text = "Select Packet";
            // 
            // cmbDeletePackets
            // 
            this.cmbDeletePackets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeletePackets.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeletePackets.FormattingEnabled = true;
            this.cmbDeletePackets.Location = new System.Drawing.Point(18, 159);
            this.cmbDeletePackets.Name = "cmbDeletePackets";
            this.cmbDeletePackets.Size = new System.Drawing.Size(277, 31);
            this.cmbDeletePackets.TabIndex = 38;
            this.cmbDeletePackets.SelectedIndexChanged += new System.EventHandler(this.cmbDeletePackets_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(87, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 27);
            this.label14.TabIndex = 36;
            this.label14.Text = "Delete Packet";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(73, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 27);
            this.label13.TabIndex = 37;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.DeepSkyBlue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Purple;
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.label13);
            this.gradientPanel1.Controls.Add(this.btnDeletePacket);
            this.gradientPanel1.Controls.Add(this.label14);
            this.gradientPanel1.Controls.Add(this.label15);
            this.gradientPanel1.Controls.Add(this.cmbDeletePackets);
            this.gradientPanel1.Location = new System.Drawing.Point(-2, -1);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(314, 321);
            this.gradientPanel1.TabIndex = 42;
            // 
            // DeletePackets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(309, 316);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletePackets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletePackets";
            this.Load += new System.EventHandler(this.DeletePackets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnDeletePacket;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbDeletePackets;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private GradientPanel gradientPanel1;
    }
}