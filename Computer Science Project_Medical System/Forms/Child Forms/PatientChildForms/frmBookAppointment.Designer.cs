namespace Computer_Science_Project_Medical_System.Forms.Child_Forms.PatientChildForms
{
    partial class frmBookAppointment
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.comboTimeStart = new System.Windows.Forms.ComboBox();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.comboTimeEnd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmAppointment = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.comboDoctorID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // comboTimeStart
            // 
            this.comboTimeStart.FormattingEnabled = true;
            this.comboTimeStart.Items.AddRange(new object[] {
            "09.00",
            "10.00",
            "11.00",
            "12.00",
            "13.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00"});
            this.comboTimeStart.Location = new System.Drawing.Point(25, 100);
            this.comboTimeStart.Name = "comboTimeStart";
            this.comboTimeStart.Size = new System.Drawing.Size(121, 21);
            this.comboTimeStart.TabIndex = 2;
            this.comboTimeStart.SelectedIndexChanged += new System.EventHandler(this.comboTimeStart_SelectedIndexChanged);
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Location = new System.Drawing.Point(22, 84);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(55, 13);
            this.lblTimeStart.TabIndex = 4;
            this.lblTimeStart.Text = "Time Start";
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Location = new System.Drawing.Point(165, 84);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(50, 13);
            this.lblTimeEnd.TabIndex = 4;
            this.lblTimeEnd.Text = "DoctorID";
            // 
            // comboTimeEnd
            // 
            this.comboTimeEnd.FormattingEnabled = true;
            this.comboTimeEnd.Location = new System.Drawing.Point(168, 46);
            this.comboTimeEnd.Name = "comboTimeEnd";
            this.comboTimeEnd.Size = new System.Drawing.Size(121, 21);
            this.comboTimeEnd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time End";
            // 
            // btnConfirmAppointment
            // 
            this.btnConfirmAppointment.Location = new System.Drawing.Point(253, 183);
            this.btnConfirmAppointment.Name = "btnConfirmAppointment";
            this.btnConfirmAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAppointment.TabIndex = 6;
            this.btnConfirmAppointment.Text = "Confirm";
            this.btnConfirmAppointment.UseVisualStyleBackColor = true;
            this.btnConfirmAppointment.Click += new System.EventHandler(this.btnConfirmAppointment_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(172, 183);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(75, 23);
            this.btnCancelBooking.TabIndex = 6;
            this.btnCancelBooking.Text = "Cancel";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // comboDoctorID
            // 
            this.comboDoctorID.FormattingEnabled = true;
            this.comboDoctorID.Location = new System.Drawing.Point(168, 100);
            this.comboDoctorID.Name = "comboDoctorID";
            this.comboDoctorID.Size = new System.Drawing.Size(121, 21);
            this.comboDoctorID.TabIndex = 2;
            this.comboDoctorID.SelectedIndexChanged += new System.EventHandler(this.comboTimeStart_SelectedIndexChanged);
            // 
            // frmBookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 218);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnConfirmAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.lblTimeStart);
            this.Controls.Add(this.comboTimeEnd);
            this.Controls.Add(this.comboDoctorID);
            this.Controls.Add(this.comboTimeStart);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmBookAppointment";
            this.Text = "frmBookAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox comboTimeStart;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.ComboBox comboTimeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmAppointment;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.ComboBox comboDoctorID;
    }
}