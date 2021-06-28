namespace Computer_Science_Project_Medical_System
{
    partial class Patient_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitPatient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 600);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome User_Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExitPatient
            // 
            this.btnExitPatient.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExitPatient.FlatAppearance.BorderSize = 0;
            this.btnExitPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitPatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExitPatient.Location = new System.Drawing.Point(970, 9);
            this.btnExitPatient.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitPatient.Name = "btnExitPatient";
            this.btnExitPatient.Size = new System.Drawing.Size(21, 23);
            this.btnExitPatient.TabIndex = 1;
            this.btnExitPatient.Text = "X";
            this.btnExitPatient.UseVisualStyleBackColor = false;
            this.btnExitPatient.Click += new System.EventHandler(this.btnExitPatient_Click);
            // 
            // Patient_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnExitPatient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_form";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitPatient;
    }
}