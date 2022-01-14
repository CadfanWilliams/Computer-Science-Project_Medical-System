using Computer_Science_Project_Medical_System.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Computer_Science_Project_Medical_System
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();


        }

        //Connection to database
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=MedicalSystem;Trusted_Connection=True;");
        //
        //
        //Opens register form
        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
            this.Hide();
        }
        // 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Variables for method
            string usertype;
            string sqlquery1; //gets record from database matching user entry
            //Sql Commands
            sqlquery1 = "SELECT * FROM tbl_users WHERE username = '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery1, con);
            //Opens the connection / connects to database
            con.Open();
            //
            SqlDataReader DataReader = cmd.ExecuteReader();
            //
            while (DataReader.Read())
            {
                //DataReader must have > 1 rows to continue
                if (DataReader.HasRows)
                {
                    usertype = DataReader.GetString(3);
                    int userid = DataReader.GetInt32(0);
                    if (usertype == "Patient")
                    {
                        new frmPatient(userid).Show();
                        this.Hide();

                    }
                    else if (usertype == "Doctor")
                    {
                        new frmDoctor(userid).Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();

                    //closes reader if no login is returned
                    DataReader.Close();
                    con.Close();
                }


            }
            DataReader.Close();
            con.Close();


        }


        //Clears all textboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        //Changes the visibility of the password textfields
        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '•';

            }
        }


        private void btnPatientSkip_Click(object sender, EventArgs e)
        {

            frmPatient frm = new frmPatient(1);
            frm.ShowDialog();
            this.Hide();
        }

        //Button To exit the form, closes whole application
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoctorSkip_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoctor frmDoctor = new frmDoctor(5);
            frmDoctor.Show();

        }
    }
}

