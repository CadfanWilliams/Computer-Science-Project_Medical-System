﻿using Computer_Science_Project_Medical_System.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Computer_Science_Project_Medical_System.Forms.Main_Forms;



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
       
        //Opens register form
        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
        // 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Variables for method
            string usertype;
            int userid;
            string sqlquery1; //gets record from database matching user entry
            //Sql Commands
            sqlquery1 = "SELECT * FROM tbl_users WHERE username = '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery1, con);
            con.Open();
            SqlDataReader DataReader = cmd.ExecuteReader();
            while (DataReader.Read())
            {
                //DataReader must have > 1 rows to continue
                if (DataReader.HasRows)
                {
                    usertype = DataReader.GetString(3);
                    userid = DataReader.GetInt32(0);

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
                    txtUsername.Focus();

                    //closes reader if no login is returned
                    DataReader.Close();
                    con.Close();
                }


            }
            DataReader.Close();
            con.Close();


        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all textboxes
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            //Changes the visibility of the password textfield
            txtPassword.PasswordChar = CheckbxShowPas.Checked == true ? '\0' : '•';
        }

        private void btnPatientSkip_Click(object sender, EventArgs e)
        {
            new frmPatient(12).Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        { Application.Exit(); }

        private void btnDoctorSkip_Click(object sender, EventArgs e)
        {
            new frmDoctor(5).Show();
            this.Hide();
        }
    }
}

