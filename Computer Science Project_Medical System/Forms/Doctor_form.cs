using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Science_Project_Medical_System
{
    public partial class Doctor_form : Form
    {
        public Doctor_form()
        {
            InitializeComponent();
        }

        private void btnExitDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnViewPatients_Click(object sender, EventArgs e)
        {
            PatientList_form PTL = new PatientList_form();
            PTL.ShowDialog();
        }

        private void btnViewLoginInfo_Click(object sender, EventArgs e)
        {
            LoginInfo_form logininfoform = new LoginInfo_form();
            logininfoform.ShowDialog();
        }
    }
}
