using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer_Science_Project_Medical_System.Forms.Child_Forms
{
    public partial class frmAppointments : Form

    {
        public int DoctorID;
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=MedicalSystem;Trusted_Connection=True;";
        public frmAppointments(int doctorid)
        {
            this.DoctorID = doctorid;
            InitializeComponent();
            getTodayDoctorAppointments(DoctorID);
            //label1.Text = DateTime.Now.ToString("d");
        }

        #region methods
        //there should be a method that saves all the appointment ids
        public void getTodayDoctorAppointments(int doctorID)
        {
            //gets the appointments that are within the coming days
            //SQL
            string date = DateTime.Now.ToString("d");
            string query = "SELECT * FROM tbl_appointments WHERE [Date Start] = '" + date + "' AND [DoctorID] = '" + doctorID + "'";
            //
            //this should in theory bring up a list of all appointments that matches system date
            // [Date Start]  = '" + date + "' AND
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
