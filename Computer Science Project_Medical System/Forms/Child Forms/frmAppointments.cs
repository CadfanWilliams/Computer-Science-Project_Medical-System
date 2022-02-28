using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer_Science_Project_Medical_System.Forms.Child_Forms
{
    public partial class frmAppointments : Form

    {
        public int UserID;
        public int DoctorID;
        public string combobox1state;
        string connectionString = "Server=tcp:medicalsystem.database.windows.net,1433;Initial Catalog=MedicalSystem;Persist Security Info=False;User ID=Cadfan;Password=Pysgotwr6352;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public frmAppointments(int userid)
        {       
            InitializeComponent();
            this.UserID = userid;
            Appointments();
            
        }

        #region methods

        public void fillDataGrid(string query)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                //Fills the data grid
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                sqlcon.Close();
                sqlda.Dispose();
            }
        }

        public void Appointments()
        {
            Doctor doctorLoggedIn = new Doctor(UserID);
            string Query = null;
            switch (combobox1state) 
            {
                //Case Today will get all appointments on the current day
                case "Today" :
                    Query = "SELECT * FROM tbl_appointments WHERE [Date] = '" + DateTime.Now.ToString("d") + "' AND DoctorID = '" + doctorLoggedIn.doctorid + "'";
                    break;
                //Case This week will get all appointments from the next 7 days
                case "This Week":
                    Query = "Select * FROM tbl_appointments WHERE [Date] >= '" + DateTime.Now.ToString("d") + "' AND [Date] <= '" + DateTime.Now.AddDays(7).ToString("d") + "' AND DoctorID = '" + doctorLoggedIn.doctorid + "'";
                    break;
                //Case This month will get the appointments within a months time
                case "This Month":
                    Query = "Select * FROM tbl_appointments WHERE [Date] >= '" + DateTime.Now.ToString("d") + "' AND [Date] <= '" + DateTime.Now.AddMonths(1).ToString("d") + "' AND DoctorID = '" + doctorLoggedIn.doctorid + "'";
                    break;
                //Case All will get all the appointments
                case "All":
                    Query = "Select * FROM tbl_appointments WHERE [DoctorID] = '" + doctorLoggedIn.doctorid + "'";
                    break;
                default:
                    Query = "SELECT * FROM tbl_appointments WHERE [Date] = '" + DateTime.Now.ToString("d") + "' AND DoctorID = '" + doctorLoggedIn.doctorid + "'";
                    break;
            }
            fillDataGrid(Query);

        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when the combobox is changed it will set the new state then refill the datatable using the new state
            combobox1state = comboBox1.Text.ToString();
            label1.Text = combobox1state;
            Appointments();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
