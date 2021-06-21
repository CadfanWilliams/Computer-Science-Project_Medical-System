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

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // user Skip
            this.Hide();
            Patient_form test = new Patient_form();
            test.ShowDialog();
            

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Doctor Skip
            this.Hide();
            Doctor_form doctor_frm = new Doctor_form();
            doctor_frm.ShowDialog();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            //Login
            if(usernameTxt.Text == "Test" && passwordTxt.Text == "Test")
            {
                //Replace with Database query for actual users from database
                button1.PerformClick();
            }
            else if (usernameTxt.Text == "Test1" && passwordTxt.Text == "Test1")
            {
                //Test for patient login
                button3.PerformClick();
                //Server = localhost\SQLEXPRESS; Database = master; Trusted_Connection = True;
            }
            else
            {
                usernameTxt.ForeColor = Color.Red;
                passwordTxt.ForeColor = Color.Red;
                usernameTxt.Text = "Incorrect";
                passwordTxt.Text = "Incorrect";
            }

        }
    }
}
