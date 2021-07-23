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

namespace Computer_Science_Project_Medical_System
{
    public partial class frmPatient : Form
    {
        //Connection to database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        //fields
        public string forename;
        public string surname;
        public int Userid;
        //methods
 
        public frmPatient(int userid)
        {
            InitializeComponent();
            Userid = userid;

            

        }




        private void btnExitPatient_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        public void setdetails()
        {

            lblForename.Text = "Welcome " + forename + " " + surname;
        }
        public void getLoginDetails()
        {

            Patient loggedin = new Patient(Userid);
            forename = loggedin.Forename;
            surname = loggedin.Surname;
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            getLoginDetails();
            setdetails();
        }
    }
}