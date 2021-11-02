using System;
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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //close all panels and open Details Panel
            pnlDetails.Show();

        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //allows user to edit txt boxes except for Docid
            txtForename.ReadOnly = false;
            txtSurname.ReadOnly = false;
            txtGender.ReadOnly = false;
            txtDob.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhonenumber.ReadOnly = false;
            txtAdd1.ReadOnly = false;
            txtAdd2.ReadOnly = false;
            txtAdd3.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtSpecialty.ReadOnly = false;
            //allows users to save the details
            btn_save.Enabled = true;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
        }
    }
}
