using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer_Science_Project_Medical_System.Forms
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        //default usertype is patient as neither doctor or patient would be set if checkbox not selected
        public string UserType = "Patient";
        //
        //Connection to database
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=MedicalSystem;Trusted_Connection=True;");
        SqlDataAdapter da = new SqlDataAdapter();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                MessageBox.Show("None of the fields should be left empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into tbl_users ([Username], [Password], [Usertype]) values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + UserType + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();



                    RegisterPatientDetails_Form EnterDetails = new RegisterPatientDetails_Form(txtUsername.Text);
                    EnterDetails.Show();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtComPassword.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                    Application.Exit();
                }

            }
            else
            {
                MessageBox.Show("Passwords Do Not Match, Please Re-Enter passwords", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void checkbxDoctor_CheckedChanged(object sender, EventArgs e)
        {
            UserType = checkbxDoctor.Checked == true ? "Doctor" : "Patient";
        }
    }
}
