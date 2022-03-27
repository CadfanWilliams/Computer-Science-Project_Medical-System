using System;
using System.Windows.Forms;

namespace Computer_Science_Project_Medical_System.Forms.Child_Forms
{
    public partial class frmDoctorDetails : Form
    {
        private int userid;
        public frmDoctorDetails(int Userid)
        {
            InitializeComponent();
            this.userid = Userid;
            setDetails();


        }
        public frmDoctorDetails()
        {
            InitializeComponent();
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            //allows user to edit txt boxes except for Docid
            //allows users to save the details
            btn_save.Enabled = true;
            //doesnt work as intended ATM
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            //also doesnt work
            btn_save.Enabled = false;
        }
        private void setDetails()
        {
            //Initiate Doctor class instance
            Doctor loggedin = new Doctor(userid);
            //fills in the text fields with data
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
            txtDocid.Text = loggedin.doctorid.ToString();
        }
    }
}
