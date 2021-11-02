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
            setDetails();
        }
        
        private void btnExitDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public void setAppointments()
        {

        }

        public void setDetails()
        {
            //Initiate Doctor class instance
            Doctor loggedin = new Doctor(Userid);
            welcomeLbl.Text = "Welcome " + loggedin.forename;
            txtForename.Text = loggedin.forename;
            txtSurname.Text = loggedin.surname;
            txtGender.Text = loggedin.gender;
            txtDob.Text = loggedin.dob;
            txtEmail.Text = loggedin.email;
            txtPhonenumber.Text = loggedin.phonenumber;
            txtAdd1.Text = loggedin.addressline1;
            txtAdd2.Text = loggedin.addressline2;
            txtAdd3.Text = loggedin.addressline3;
            txtPostcode.Text = loggedin.postcode;
            txtSpecialty.Text = loggedin.specialty;
            txtDocid.Text = loggedin.Userid.ToString();
        }
    }
}
