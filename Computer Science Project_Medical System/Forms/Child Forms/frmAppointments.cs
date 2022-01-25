using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Data;

namespace Computer_Science_Project_Medical_System.Forms.Child_Forms
{
    public partial class frmAppointments : Form
    {
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=MedicalSystem;Trusted_Connection=True;";
        public frmAppointments()
        {
            InitializeComponent();
        }

        #region methods
        //there should be a method that saves all the appointment ids
        public void getTodayDoctorAppointments(string doctorID)
        {
            //gets the appointments that are within the coming days
            //SQL
            string date = DateTime.Now.ToString("d");
            string query = "SELECT * FROM tbl_appointments WHERE Datestart  = '" + date + "' AND doctorid = '" + doctorID +"'";
            //this should in theory bring up a list of all appointments that matches system date

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
            }
        }
        #endregion
    }
}
