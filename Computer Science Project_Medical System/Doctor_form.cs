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
    }
}
