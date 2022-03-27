using System.Data.SqlClient;


namespace Computer_Science_Project_Medical_System
{
    class Doctor
    {
        #region variables
        //Connection to database
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=MedicalSystem;Trusted_Connection=True;");
        //SqlConnection con = new SqlConnection("Server = tcp:medicalsystem.database.windows.net, 1433; Initial Catalog = MedicalSystem; Persist Security Info=False;User ID = Cadfan; Password=Pysgotwr6352;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");

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
        public string specialty;
        public int Userid;
        #endregion
        #region constructors
        public Doctor(int userid)
        {
            this.Userid = userid;
            getDoctorDetails();
        }
        #endregion
        #region methods

        public void getDoctorDetails()
        {
            //Get details of the doctor
            //Sql Commands
            string query = "SELECT * FROM tbl_doctors WHERE userid = '" + Userid + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader DataReader = cmd.ExecuteReader();

            while (DataReader.Read())
            {
                this.doctorid = DataReader.GetInt32(0);
                this.forename = DataReader.GetString(1);
                this.surname = DataReader.GetString(2);
                this.gender = DataReader.GetString(3);
                this.dob = DataReader.GetDateTime(4).ToShortDateString();
                this.email = DataReader.GetString(5);
                this.phonenumber = DataReader.GetString(6);
                this.addressline1 = DataReader.GetString(7);
                this.addressline2 = DataReader.GetString(8);
                this.addressline3 = DataReader.GetString(9);
                this.postcode = DataReader.GetString(10);
                this.specialty = DataReader.GetString(12);
            }
            DataReader.Close();
        }

        public void saveDetails()
        {
            //Saves the doctors details/ Appends the details
            //string query = "UPDATE Doctor(Forename, Surname, Gender, DOB, Email, Phonenumber, Addressline1, Addressline2, Addressline3, Postcode, Specialty) VALUES () WHERE Docid ='" + doctorid + "'";
        }
        #endregion
    }
}
