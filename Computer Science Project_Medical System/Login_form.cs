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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_form test = new Patient_form();
            test.ShowDialog();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_form doctor_frm = new Doctor_form();
            doctor_frm.ShowDialog();
        }
    }
}
