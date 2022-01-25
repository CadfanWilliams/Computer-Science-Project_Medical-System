using Computer_Science_Project_Medical_System.Forms.Child_Forms;
using System;
using System.Windows.Forms;
namespace Computer_Science_Project_Medical_System
{
    public partial class frmDoctor : Form
    {
        //feilds
        //Fields For the doctor class
        public int doctorid;
        public string forename;
        public string surname;
        public string gender;
        public string dob;
        public string email;
        public string phonenumber;
        public string addressline1;
        public string addressline2;
        public string addressline3;
        public string postcode;
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

        private void setAppointments()
        {

        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoctorDetails(Userid));
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {

        }
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAppointments());
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
