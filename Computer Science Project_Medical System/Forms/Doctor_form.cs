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
    public partial class frmDoctor : Form
    {
        //feilds
        //Fields For the doctor class
        public int doctorid;
        public string forename;
        public string surname;
        public string gender;
        public string dob;
        public string email;
        public string phonenumber;
        public string addressline1;
        public string addressline2;
        public string addressline3;
        public string postcode;
        public int Userid;
        //Methods

        public frmDoctor(int userid)
        {
            InitializeComponent();
            this.Userid = userid;
        }
        
        private void btnExitDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public void setAppointments()
        {

        }

        public void getAppointments()
        {
            Doctor loggedin = new Doctor(Userid);

        }
    }
}
