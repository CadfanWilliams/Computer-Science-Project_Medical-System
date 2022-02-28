using Computer_Science_Project_Medical_System.Forms.Child_Forms;
using System;
using System.Windows.Forms;
namespace Computer_Science_Project_Medical_System
{
    public partial class frmDoctor : Form
    {

        public int Userid;
        //Field for active form 
        private Form activeForm = null;
        //Methods

        public frmDoctor(int userid)
        {
            InitializeComponent();
            this.Userid = userid;
            Doctor doctorLoggedIn = new Doctor(userid);
            welcomeLbl.Text = welcomeLbl.Text + " " + doctorLoggedIn.forename;
        }
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnExitDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoctorDetails(Userid));
        }
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAppointmentsDoctor(Userid));
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
    }
}
