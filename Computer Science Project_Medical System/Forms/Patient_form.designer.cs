namespace Computer_Science_Project_Medical_System
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitPatient = new System.Windows.Forms.Button();
            this.lblForename = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.lblForename);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 600);
            this.panel1.TabIndex = 0;
            // 
            // btnExitPatient
            // 
            this.btnExitPatient.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExitPatient.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(12, 134);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(77, 17);
            this.lblForename.TabIndex = 2;
            this.lblForename.Text = "Welcome...";
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnExitPatient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExitPatient;
        private System.Windows.Forms.Label lblForename;
    }
}