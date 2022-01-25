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
            getTodayDoctorAppointments("5");
        }

        #region methods
        //there should be a method that saves all the appointment ids
        public void getTodayDoctorAppointments(string doctorID)
        {
            //gets the appointments that are within the coming days
            //SQL
            string date = DateTime.Now.ToString();
            string query = "SELECT * FROM tbl_appointments WHERE DoctorID = '" + doctorID +"'";
            //this should in theory bring up a list of all appointments that matches system date
            // [Date Start]  = '" + date + "' AND
            using(SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                sqlcon.Close();
                sqlda.Dispose();

                
            }
        }
        #endregion
    }
}
