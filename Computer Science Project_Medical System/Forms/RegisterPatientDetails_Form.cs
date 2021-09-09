using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Computer_Science_Project_Medical_System.Forms
{
    public partial class RegisterPatientDetails_Form : Form
    {
        //Connection to database
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS01;Database=Medical System;Trusted_Connection=True;");
        SqlDataAdapter da = new SqlDataAdapter();
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

        //Methods

        private void RegisterPatientDetails_Form_Load(object sender, EventArgs e)
        {
            getuserid(Username);
        }

       
        private void btnRegister_Click(object sender, EventArgs e)
        {

            if(checkpresence() == false)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into tbl_patients ([forename], [surname], [gender], [dob], [email], [phonenumber], [addressline1], [addressline2], [addressline3], [postcode],[userid]) values ('" + txtFirstname.Text + "','" + txtSurname.Text + "','" + comboBox1.SelectedValue + "','" + dtpDob.Value.Date + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "','" + txtAddress3.Text + "','" + txtPostcode.Text + "','" + Userid + "')";
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
            if (txtFirstname.Text == null || txtSurname.Text == null || txtEmail.Text == null || txtPhone.Text == null || txtAddress1.Text == null || txtAddress2.Text == null || txtAddress3.Text == null || txtPostcode.Text == null || dtpDob == null || comboBox1 == null)
            {
                MessageBox.Show("You must fill all the boxes");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void getuserid(string username1)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_users WHERE username = '" + username1 + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader DataReader = cmd.ExecuteReader();
            
            while (DataReader.Read())
            {
                Userid = DataReader.GetInt32(0);
            }
            
            DataReader.Close();
            con.Close();
        }
        

                    
        
       
    }
}
