﻿using System;
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        //string for doctor
        public string UserType = "Patient";
        //Connection to database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                MessageBox.Show("None of the fields should be left empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into tbl_users ([username], [password], [usertype]) values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + UserType + "')";              
                    cmd.ExecuteNonQuery();
                    con.Close();

                    

                    RegisterPatientDetails_Form EnterDetails = new RegisterPatientDetails_Form(txtUsername.Text);
                    EnterDetails.Show();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtComPassword.Text = "";

                } catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                    Application.Exit();
                }
                

                MessageBox.Show("Your Account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords Do Not Match, Please Re-Enter passwords","Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error );
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
            if(checkbxDoctor.Checked == true)
            {
                UserType = "Doctor";
            }
            else
            {
                UserType = "Patient";
            }
        }
    }
}