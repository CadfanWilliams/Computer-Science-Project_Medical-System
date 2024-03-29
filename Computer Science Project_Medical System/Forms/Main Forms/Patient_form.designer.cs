﻿namespace Computer_Science_Project_Medical_System.Forms.Main_Forms
{
    partial class frmPatient
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
            this.pnlPatient1 = new System.Windows.Forms.Panel();
            this.btnReferrals = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExitDoctor = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pnlPatient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatient1
            // 
            this.pnlPatient1.BackColor = System.Drawing.Color.DimGray;
            this.pnlPatient1.Controls.Add(this.btnReferrals);
            this.pnlPatient1.Controls.Add(this.btnAppointments);
            this.pnlPatient1.Controls.Add(this.btnDetails);
            this.pnlPatient1.Controls.Add(this.panel1);
            this.pnlPatient1.Controls.Add(this.welcomeLbl);
            this.pnlPatient1.Controls.Add(this.userPicture);
            this.pnlPatient1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPatient1.Location = new System.Drawing.Point(0, 0);
            this.pnlPatient1.Name = "pnlPatient1";
            this.pnlPatient1.Size = new System.Drawing.Size(180, 600);
            this.pnlPatient1.TabIndex = 1;
            // 
            // btnReferrals
            // 
            this.btnReferrals.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReferrals.FlatAppearance.BorderSize = 0;
            this.btnReferrals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReferrals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnReferrals.Location = new System.Drawing.Point(0, 332);
            this.btnReferrals.Name = "btnReferrals";
            this.btnReferrals.Size = new System.Drawing.Size(180, 80);
            this.btnReferrals.TabIndex = 5;
            this.btnReferrals.Text = "Referrals";
            this.btnReferrals.UseVisualStyleBackColor = false;
            // 
            // btnAppointments
            // 
            this.btnAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointments.FlatAppearance.BorderSize = 0;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.Location = new System.Drawing.Point(0, 252);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(180, 80);
            this.btnAppointments.TabIndex = 3;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.DimGray;
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnDetails.Location = new System.Drawing.Point(0, 172);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(180, 80);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(179, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 28);
            this.panel1.TabIndex = 4;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.welcomeLbl.Location = new System.Drawing.Point(0, 155);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(65, 17);
            this.welcomeLbl.TabIndex = 1;
            this.welcomeLbl.Text = "Welcome";
            // 
            // userPicture
            // 
            this.userPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPicture.Image = global::Computer_Science_Project_Medical_System.Properties.Resources.patienticon;
            this.userPicture.Location = new System.Drawing.Point(0, 0);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(180, 155);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btnExitDoctor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 31);
            this.panel2.TabIndex = 5;
            // 
            // btnExitDoctor
            // 
            this.btnExitDoctor.BackColor = System.Drawing.Color.DimGray;
            this.btnExitDoctor.FlatAppearance.BorderSize = 0;
            this.btnExitDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitDoctor.Location = new System.Drawing.Point(790, 3);
            this.btnExitDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitDoctor.Name = "btnExitDoctor";
            this.btnExitDoctor.Size = new System.Drawing.Size(21, 23);
            this.btnExitDoctor.TabIndex = 2;
            this.btnExitDoctor.Text = "X";
            this.btnExitDoctor.UseVisualStyleBackColor = false;
            this.btnExitDoctor.Click += new System.EventHandler(this.btnExitDoctor_Click_1);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.LightGray;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(180, 31);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(820, 569);
            this.panelChildForm.TabIndex = 6;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPatient1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            this.pnlPatient1.ResumeLayout(false);
            this.pnlPatient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPatient1;
        private System.Windows.Forms.Button btnReferrals;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExitDoctor;
        private System.Windows.Forms.Panel panelChildForm;
    }
}