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
            this.SuspendLayout();
            // 
            // pnlDoctor1
            // 
            this.pnlDoctor1.BackColor = System.Drawing.Color.DimGray;
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
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnExitDoctor);
            this.Controls.Add(this.pnlDoctor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doctor_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDoctor1;
        private System.Windows.Forms.Button btnExitDoctor;
    }
}