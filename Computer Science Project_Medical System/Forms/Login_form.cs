using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Science_Project_Medical_System
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Patient Skip
            this.Hide();
            frmPatient test = new frmPatient();
            test.ShowDialog();
            

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Doctor Skip
            this.Hide();
            frmDoctor doctor_frm = new frmDoctor();
            doctor_frm.ShowDialog();
        }

       


    }
}

