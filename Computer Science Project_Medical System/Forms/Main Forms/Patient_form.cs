using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_Science_Project_Medical_System.Forms.Child_Forms.PatientChildForms;

namespace Computer_Science_Project_Medical_System.Forms.Main_Forms
{
    public partial class frmPatient : Form
    {
        #region Variables
        public int UserID;
        //field for the active child form
        private Form activeForm = null;
        #endregion
        public frmPatient(int userid)
        {
            InitializeComponent();
            this.UserID = userid;
            Patient patientLoggedIn = new Patient(userid);
            welcomeLbl.Text = welcomeLbl.Text +  " " + patientLoggedIn.forename;
        }
        private void btnExitDoctor_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public void openChildForm(Form childForm)
        {
            //method for opening a form onto a panel
            //for it to be called = openChildForm(new frmAppointment()); - example
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPatientDetails(UserID));
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAppointmentsPatient(UserID));
        }
    }
}
