using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Science_Project_Medical_System.Forms.Child_Forms.PatientChildForms
{
    public partial class frmPatientDetails : Form
    {
        public int UserID;
        public frmPatientDetails(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
            setDetails();
        }
        public void setDetails()
        {
            Patient loggedin = new Patient(UserID);
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
            txtPatientID.Text = loggedin.patientid.ToString();
        }
    }
}
