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
    public partial class frmPatient : Form
    {
        

        //fields
        public int patientid;
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
        //methods

        public frmPatient(int userid)
        {
            InitializeComponent();
            Userid = userid;
            getPatientDetails();
            setPatientDetails();

        }

        //Closes the application
        private void btnExitPatient_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            getPatientDetails();
        }
        //Sets the details of the patient to the labels on the form
        public void setPatientDetails()
        {

            lblForename.Text = "Welcome " + forename + " " + surname;
            patientid1.Text = patientid.ToString();
            label12.Text = forename;
            label13.Text = surname;
            label14.Text = gender;
            label15.Text = dob;
            label16.Text = email;
            label17.Text = phonenumber;
            label18.Text = addressline1;
            label19.Text = addressline2;
            label20.Text = addressline3;
            label21.Text = postcode;

        }
        //gets the details of the patient logging in from tbl_patients
        public void getPatientDetails()
        { 
            Patient loggedin = new Patient(Userid);
            forename = loggedin.forename;
            surname = loggedin.surname;
            gender = loggedin.gender;
            dob = loggedin.dob;
            email = loggedin.email;
            phonenumber = loggedin.phonenumber;
            addressline1 = loggedin.addressline1;
            addressline2 = loggedin.addressline2;
            addressline3 = loggedin.addressline3;
            postcode = loggedin.postcode;



        }

        private void lblEdit_Click(object sender, EventArgs e)
        {

        }
    }
}