using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Computer_Science_Project_Medical_System.Forms.Child_Forms.PatientChildForms
{
    public partial class CancelAppointmentPopupBox : Form
    {
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=MedicalSystem;Trusted_Connection=True;";
        public CancelAppointmentPopupBox()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int AppointmentID = int.Parse(txtboxAppointmentID.Text);
            SqlConnection sqlConnection= new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_appointments WHERE [AppointmentID] = '" + AppointmentID + "'" , sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            this.Close();
        }
    }
}
