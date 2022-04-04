using System;
using System.Windows.Forms;
using System.Data.SqlClient;
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txtAdd1.Enabled = true;
            txtAdd2.Enabled = true;
            txtAdd3.Enabled = true;
            txtDob.Enabled = true;
            txtEmail.Enabled = true;
            txtForename.Enabled = true;
            txtGender.Enabled = true;
            txtPatientID.Enabled = true;
            txtPhonenumber.Enabled = true;
            txtPostcode.Enabled = true;
            txtSurname.Enabled = true;
            btn_save.Enabled = true;
            btnCancel.Enabled = true;
            btn_edit.Enabled = false;

            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAdd1.Enabled = false;
            txtAdd2.Enabled = false;
            txtAdd3.Enabled = false;
            txtDob.Enabled = false;
            txtEmail.Enabled = false;
            txtForename.Enabled = false;
            txtGender.Enabled = false;
            txtPatientID.Enabled = false;
            txtPhonenumber.Enabled = false;
            txtPostcode.Enabled = false;
            txtSurname.Enabled = false;
            btn_save.Enabled = false;
            btnCancel.Enabled = false;
            btn_edit.Enabled = true;
            setDetails();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=MedicalSystem;Trusted_Connection=True;");
            string query =
            "UPDATE tbl_patient SET ([Forename], [Surname], [Gender], [DOB], [Email], [Phonenumber], [Addressline1], [Addressline2], [Addressline3], [Postcode]) values ('" + txtForename.Text + "','" + txtSurname.Text + "','" + txtGender.Text + "','" + txtDob + "','" + txtEmail.Text + "','" + txtPhonenumber.Text + "','" + txtAdd1.Text + "','" + txtAdd2.Text + "','" + txtAdd3.Text + "','" + txtPostcode.Text + "') Where UserID = '" + UserID + "'";
            SqlCommand cmd = new SqlCommand(query, con );
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            txtAdd1.Enabled = false;
            txtAdd2.Enabled = false;
            txtAdd3.Enabled = false;
            txtDob.Enabled = false;
            txtEmail.Enabled = false;
            txtForename.Enabled = false;
            txtGender.Enabled = false;
            txtPatientID.Enabled = false;
            txtPhonenumber.Enabled = false;
            txtPostcode.Enabled = false;
            txtSurname.Enabled = false;
            btn_save.Enabled = false;
            btnCancel.Enabled = false;
            btn_edit.Enabled = true;
            setDetails();


        }
    }
}
