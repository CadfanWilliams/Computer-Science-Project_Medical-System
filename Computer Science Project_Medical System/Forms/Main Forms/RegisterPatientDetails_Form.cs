using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Computer_Science_Project_Medical_System.Forms
{
    public partial class RegisterPatientDetails_Form : Form
    {
        //Connection to database
        SqlConnection con = new SqlConnection("Server = tcp:medicalsystem.database.windows.net, 1433; Initial Catalog = MedicalSystem; Persist Security Info=False;User ID = Cadfan; Password=Pysgotwr6352;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
        //
        //Constructors
        public RegisterPatientDetails_Form()
        {
            InitializeComponent();
        }
        public RegisterPatientDetails_Form(string username)
        {
            InitializeComponent();
            this.Username = username;
            getuserid(Username);
        }
        //Fields
        public int Userid;
        public string Username;
        public string usertype;

        //Methods

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (checkpresence())
            {

                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    //depending on usertype will insert the record
                    if (usertype == "Patient")
                    {
                        cmd.CommandText = "insert into tbl_patients ([Forename], [Surname], [Gender], [DOB], [Email], [Phonenumber], [Addressline1], [Addressline2], [Addressline3], [Postcode],[Userid]) values ('" + txtFirstname.Text + "','" + txtSurname.Text + "','" + comboBox1.Text + "','" + dtpDob.Value.Date.ToString() + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "','" + txtAddress3.Text + "','" + txtPostcode.Text + "','" + Userid + "')";

                    }
                    else if (usertype == "Doctor")
                    {
                        cmd.CommandText = "insert into tbl_doctors ([Forename], [Surname], [Gender], [DOB], [Email], [Phonenumber], [Addressline1], [Addressline2], [Addressline3], [Postcode],[Userid],[Specialty]) values ('" + txtFirstname.Text + "','" + txtSurname.Text + "','" + comboBox1.Text + "','" + dtpDob.Value.Date.ToString() + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "','" + txtAddress3.Text + "','" + txtPostcode.Text + "','" + Userid + "','" + "Heart Surgon" + "')";

                    }
                    cmd.ExecuteNonQuery();

                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                    Application.Exit();
                }
            }
            this.Close();
        }

        //Presence Check
        public bool checkpresence()
        {
            //basic presence check
            if (txtFirstname.Text == null || txtSurname.Text == null || txtEmail.Text == null || txtPhone.Text == null || txtAddress1.Text == null
             || txtAddress2.Text == null || txtAddress3.Text == null || txtPostcode.Text == null || dtpDob == null || comboBox1 == null)
            {
                MessageBox.Show("You must fill all the boxes");
                return false;
            }
            else { return true; }
        }
        public void getuserid(string username1)
        {
            //this will get the user id of the user creating account so it can link the two tables together using USERID
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_users WHERE username = '" + username1 + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader DataReader = cmd.ExecuteReader();

            while (DataReader.Read())
            {
                Userid = DataReader.GetInt32(0);
                usertype = DataReader.GetString(3);
            }

            DataReader.Close();
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtAddress3.Clear();
            txtEmail.Clear();
            txtFirstname.Clear();
            txtPhone.Clear();
            txtPostcode.Clear();
            txtSurname.Clear();
        }
    }
}
