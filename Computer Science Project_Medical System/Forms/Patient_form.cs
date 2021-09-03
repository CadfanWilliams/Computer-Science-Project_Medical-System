using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Computer_Science_Project_Medical_System
{
    public partial class frmPatient : Form
    {
        //Connection to database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
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

            

        }




        private void btnExitPatient_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        public void setdetails()
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
        public void getLoginDetails()
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

        private void frmPatient_Load(object sender, EventArgs e)
        {
            getLoginDetails();
            setdetails();
        }
    }
}