namespace Computer_Science_Project_Medical_System
{
    partial class frmDoctor
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
            this.pnlDoctor1 = new System.Windows.Forms.Panel();
            this.btnExitDoctor = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.lblAdd3 = new System.Windows.Forms.Label();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDocid = new System.Windows.Forms.Label();
            this.txtDocid = new System.Windows.Forms.TextBox();
            this.pnlDoctor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDoctor1
            // 
            this.pnlDoctor1.BackColor = System.Drawing.Color.DimGray;
            this.pnlDoctor1.Controls.Add(this.btnDetails);
            this.pnlDoctor1.Controls.Add(this.welcomeLbl);
            this.pnlDoctor1.Controls.Add(this.userPicture);
            this.pnlDoctor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDoctor1.Location = new System.Drawing.Point(0, 0);
            this.pnlDoctor1.Name = "pnlDoctor1";
            this.pnlDoctor1.Size = new System.Drawing.Size(180, 600);
            this.pnlDoctor1.TabIndex = 0;
            // 
            // btnExitDoctor
            // 
            this.btnExitDoctor.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExitDoctor.FlatAppearance.BorderSize = 0;
            this.btnExitDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitDoctor.Location = new System.Drawing.Point(970, 9);
            this.btnExitDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitDoctor.Name = "btnExitDoctor";
            this.btnExitDoctor.Size = new System.Drawing.Size(21, 23);
            this.btnExitDoctor.TabIndex = 2;
            this.btnExitDoctor.Text = "X";
            this.btnExitDoctor.UseVisualStyleBackColor = false;
            this.btnExitDoctor.Click += new System.EventHandler(this.btnExitDoctor_Click);
            // 
            // userPicture
            // 
            this.userPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPicture.Image = global::Computer_Science_Project_Medical_System.Properties.Resources.user_icon;
            this.userPicture.Location = new System.Drawing.Point(0, 0);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(180, 155);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.welcomeLbl.Location = new System.Drawing.Point(3, 138);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(81, 17);
            this.welcomeLbl.TabIndex = 1;
            this.welcomeLbl.Text = "Welcome ...";
            // 
            // btnDetails
            // 
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(0, 155);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(180, 52);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.txtDocid);
            this.pnlDetails.Controls.Add(this.lblDocid);
            this.pnlDetails.Controls.Add(this.txtPostcode);
            this.pnlDetails.Controls.Add(this.lblPostcode);
            this.pnlDetails.Controls.Add(this.txtAdd2);
            this.pnlDetails.Controls.Add(this.lblAdd2);
            this.pnlDetails.Controls.Add(this.txtPhonenumber);
            this.pnlDetails.Controls.Add(this.lblPhonenumber);
            this.pnlDetails.Controls.Add(this.txtDob);
            this.pnlDetails.Controls.Add(this.lblDob);
            this.pnlDetails.Controls.Add(this.txtSurname);
            this.pnlDetails.Controls.Add(this.lblSurname);
            this.pnlDetails.Controls.Add(this.txtSpecialty);
            this.pnlDetails.Controls.Add(this.lblSpecialty);
            this.pnlDetails.Controls.Add(this.txtAdd3);
            this.pnlDetails.Controls.Add(this.lblAdd3);
            this.pnlDetails.Controls.Add(this.txtAdd1);
            this.pnlDetails.Controls.Add(this.lblAdd1);
            this.pnlDetails.Controls.Add(this.txtEmail);
            this.pnlDetails.Controls.Add(this.lblEmail);
            this.pnlDetails.Controls.Add(this.txtGender);
            this.pnlDetails.Controls.Add(this.lblGender);
            this.pnlDetails.Controls.Add(this.txtForename);
            this.pnlDetails.Controls.Add(this.lblForename);
            this.pnlDetails.Location = new System.Drawing.Point(186, 44);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(802, 544);
            this.pnlDetails.TabIndex = 3;
            // 
            // txtForename
            // 
            this.txtForename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForename.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(23, 40);
            this.txtForename.Multiline = true;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(216, 28);
            this.txtForename.TabIndex = 16;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(20, 20);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 15;
            this.lblForename.Text = "Forename";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGender.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(23, 90);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(216, 28);
            this.txtGender.TabIndex = 18;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 70);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "Gender";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(23, 140);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 28);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // txtAdd1
            // 
            this.txtAdd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAdd1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdd1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.Location = new System.Drawing.Point(23, 190);
            this.txtAdd1.Multiline = true;
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(216, 28);
            this.txtAdd1.TabIndex = 22;
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Location = new System.Drawing.Point(20, 170);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(77, 13);
            this.lblAdd1.TabIndex = 21;
            this.lblAdd1.Text = "Address Line 1";
            // 
            // txtAdd3
            // 
            this.txtAdd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAdd3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdd3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd3.Location = new System.Drawing.Point(23, 240);
            this.txtAdd3.Multiline = true;
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.Size = new System.Drawing.Size(216, 28);
            this.txtAdd3.TabIndex = 24;
            // 
            // lblAdd3
            // 
            this.lblAdd3.AutoSize = true;
            this.lblAdd3.Location = new System.Drawing.Point(20, 220);
            this.lblAdd3.Name = "lblAdd3";
            this.lblAdd3.Size = new System.Drawing.Size(77, 13);
            this.lblAdd3.TabIndex = 23;
            this.lblAdd3.Text = "Address Line 3";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSpecialty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpecialty.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialty.Location = new System.Drawing.Point(23, 290);
            this.txtSpecialty.Multiline = true;
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(216, 28);
            this.txtSpecialty.TabIndex = 26;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(20, 270);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(50, 13);
            this.lblSpecialty.TabIndex = 25;
            this.lblSpecialty.Text = "Specialty";
            // 
            // txtPostcode
            // 
            this.txtPostcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostcode.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(270, 240);
            this.txtPostcode.Multiline = true;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(216, 28);
            this.txtPostcode.TabIndex = 36;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(267, 220);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(56, 13);
            this.lblPostcode.TabIndex = 35;
            this.lblPostcode.Text = "Post Code";
            // 
            // txtAdd2
            // 
            this.txtAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAdd2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdd2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd2.Location = new System.Drawing.Point(270, 190);
            this.txtAdd2.Multiline = true;
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(216, 28);
            this.txtAdd2.TabIndex = 34;
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Location = new System.Drawing.Point(267, 170);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(77, 13);
            this.lblAdd2.TabIndex = 33;
            this.lblAdd2.Text = "Address Line 2";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPhonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonenumber.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhonenumber.Location = new System.Drawing.Point(270, 140);
            this.txtPhonenumber.Multiline = true;
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(216, 28);
            this.txtPhonenumber.TabIndex = 32;
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(267, 120);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhonenumber.TabIndex = 31;
            this.lblPhonenumber.Text = "Phone Number";
            // 
            // txtDob
            // 
            this.txtDob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtDob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDob.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDob.Location = new System.Drawing.Point(270, 90);
            this.txtDob.Multiline = true;
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(216, 28);
            this.txtDob.TabIndex = 30;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(267, 70);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(66, 13);
            this.lblDob.TabIndex = 29;
            this.lblDob.Text = "Date of Birth";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(270, 40);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(216, 28);
            this.txtSurname.TabIndex = 28;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(267, 20);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 27;
            this.lblSurname.Text = "Surname";
            // 
            // lblDocid
            // 
            this.lblDocid.AutoSize = true;
            this.lblDocid.Location = new System.Drawing.Point(267, 270);
            this.lblDocid.Name = "lblDocid";
            this.lblDocid.Size = new System.Drawing.Size(53, 13);
            this.lblDocid.TabIndex = 37;
            this.lblDocid.Text = "Doctor ID";
            // 
            // txtDocid
            // 
            this.txtDocid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtDocid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocid.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocid.Location = new System.Drawing.Point(270, 290);
            this.txtDocid.Multiline = true;
            this.txtDocid.Name = "txtDocid";
            this.txtDocid.Size = new System.Drawing.Size(216, 28);
            this.txtDocid.TabIndex = 38;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.btnExitDoctor);
            this.Controls.Add(this.pnlDoctor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doctor_form";
            this.pnlDoctor1.ResumeLayout(false);
            this.pnlDoctor1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDoctor1;
        private System.Windows.Forms.Button btnExitDoctor;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TextBox txtDocid;
        private System.Windows.Forms.Label lblDocid;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.TextBox txtAdd3;
        private System.Windows.Forms.Label lblAdd3;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
    }
}