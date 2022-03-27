using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer_Science_Project_Medical_System.Forms.Child_Forms.PatientChildForms
{
    public partial class frmAppointmentsPatient : Form
    {
        public int UserID;
        public int PatientID;
        public string combobox1state;
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=MedicalSystem;Trusted_Connection=True;";
        public frmAppointmentsPatient(int userid)
        {
            UserID = userid;
            InitializeComponent();
        }
        public void fillDataGrid(string query)
        {
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
        public void Appointments()
        {
            Patient patientLoggedIn = new Patient(UserID);
            string Query = null;
            switch (combobox1state)
            {
                //Case Today will get all appointments on the current day
                case "Today":
                    Query = "SELECT * FROM tbl_appointments WHERE [Date] = '" + DateTime.Now.ToString("d") + "' AND PatientID = '" + patientLoggedIn.patientid + "'";
                    break;
                //Case This week will get all appointments from the next 7 days
                case "This Week":
                    Query = "Select * FROM tbl_appointments WHERE [Date] >= '" + DateTime.Now.ToString("d") + "' AND [Date] <= '" + DateTime.Now.AddDays(7).ToString("d") + "' AND PatientID = '" + patientLoggedIn.patientid + "'";
                    break;
                //Case This month will get the appointments within a months time
                case "This Month":
                    Query = "Select * FROM tbl_appointments WHERE [Date] >= '" + DateTime.Now.ToString("d") + "' AND [Date] <= '" + DateTime.Now.AddMonths(1).ToString("d") + "' AND DoctorID = '" + patientLoggedIn.patientid + "'";
                    break;
                //Case All will get all the appointments
                case "All":
                    Query = "Select * FROM tbl_appointments WHERE [PatientID] = '" + patientLoggedIn.patientid + "'";
                    break;
                case "Upcoming":
                    Query = "Select * FROM tbl_appointments WHERE [Date] >= '" + DateTime.Now.ToString("d") + "' AND PatientID = '" + patientLoggedIn.patientid + "'";
                    break;
                default:
                    Query = "SELECT * FROM tbl_appointments WHERE [Date] = '" + DateTime.Now.ToString("d") + "' AND PatientID = '" + patientLoggedIn.patientid + "'";
                    break;
            }
            fillDataGrid(Query);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox1state = comboBox1.Text.ToString();
            Appointments();
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
           new CancelAppointmentPopupBox().ShowDialog();
           Appointments();

            
        }
    }
}
