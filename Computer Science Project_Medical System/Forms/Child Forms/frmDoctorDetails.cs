using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void setDetails()
        {
            //Initiate Doctor class instance
            Doctor loggedin = new Doctor(userid);
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
