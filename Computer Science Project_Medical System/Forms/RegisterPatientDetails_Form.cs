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

namespace Computer_Science_Project_Medical_System.Forms
{
    public partial class RegisterPatientDetails_Form : Form
    {
        //Connection to database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
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

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into tbl_patients ([forename], [surname], [gender], [dob], [email], [phonenumber], [addressline1], [addressline2], [addressline3], [postcode],[userid]) values ('" + txtFirstname.Text + "','" + txtSurname.Text + "','" + comboBox1.SelectedValue + "','" + dtpDob.Value + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "','" + txtAddress3.Text + "','" + txtPostcode.Text + "','" + Userid + "')";
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

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbl_users WHERE username = '" + username1 + "'";
            cmd.ExecuteNonQuery();
            OleDbDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                Userid = dr.GetInt32(0);
            }
            
            dr.Close();
            con.Close();
        }
        

                    
        
       
    }
}
