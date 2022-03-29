using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Computer_Science_Project_Medical_System.Forms.Child_Forms.PatientChildForms
{
    public partial class frmBookAppointment : Form
    {
        SqlConnection connectionString = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=MedicalSystem;Trusted_Connection=True;");
        int PatientID;
        public frmBookAppointment(int patientID)
        {
            InitializeComponent();
            fillDoctorID();
            this.PatientID = patientID;
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboTimeStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string timestart;
            string timeend;

            float timestart1;
            timestart = comboTimeStart.Text.ToString();
            timestart1 = float.Parse(timestart);
            timestart1 = timestart1 + 1;
            timeend = timestart1.ToString() + ":00";
            comboTimeEnd.Text = timeend;
        }
        private void fillDoctorID()
        {
            string query = "SELECT DoctorID FROM tbl_doctors";
            SqlCommand cmd = new SqlCommand(query, connectionString);
            connectionString.Open();
            SqlDataReader DataReader = cmd.ExecuteReader();
            
            while (DataReader.Read())
            {
                comboDoctorID.Items.Add(DataReader.GetInt32(0).ToString());
            }
            connectionString.Close();
        }

        private void btnConfirmAppointment_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value == null || comboDoctorID.Text == "" || comboTimeStart.Text == "" || comboTimeEnd.Text == "")
            {
                MessageBox.Show("All Boxes must be filled");
            }
            else
            {
                try
                {
                    
                    connectionString.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connectionString;
                    cmd.CommandText = "Insert into tbl_appointments ([PatientID], [DoctorID], [Date], [Time Start], [Time End]) values ('" + PatientID + "','" + comboDoctorID.Text + "', '" + dateTimePicker1.Value.ToString("d") + "','" + comboTimeStart.Text + "','" + comboTimeEnd.Text + "')";

                    cmd.ExecuteNonQuery();
                    connectionString.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                    throw;
                }
                finally
                {
                    connectionString.Close();
                }
                
            }
        }
    }
}
