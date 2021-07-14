using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Computer_Science_Project_Medical_System.Forms;


namespace Computer_Science_Project_Medical_System
{
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            
        }

        //Connection to database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username = '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            string usertype;
            while (dr.Read())
            {
                usertype = dr.GetString(3);
                int userid2 = dr.GetInt32(0);
                if (usertype == "Patient")
                {
                    new frmPatient(userid2).Show();
                    this.Hide();
                  
                }
                else if (usertype == "Doctor")
                {
                    frmDoctor doc = new frmDoctor();
                    doc.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Invalid Login", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                    
                }
                
            }
            dr.Close();

            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

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
           
            frmPatient frm = new frmPatient(3);
            frm.Show();
            this.Hide();
        }
        
    }
}

