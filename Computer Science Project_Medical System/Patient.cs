using System.Data.SqlClient;


namespace Computer_Science_Project_Medical_System
{
    class Patient
    {
        #region variables
        //Connection to database
        SqlConnection con = new SqlConnection("Server = tcp:medicalsystem.database.windows.net, 1433; Initial Catalog = MedicalSystem; Persist Security Info=False;User ID = Cadfan; Password=Pysgotwr6352;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");

        public int patientid;
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
        #endregion
        #region constructors
        public Patient(int userid)
        {
            this.Userid = userid;
            getPatientDetails();
        }
        #endregion
        #region methods
        public void getPatientDetails()
        {
            //Gets the details of the patient
            //SQL Commands
            string Query = "SELECT * FROM tbl_patients WHERE UserID = '" + Userid + "'";
            SqlCommand cmd = new SqlCommand(Query, con);

            con.Open();
            SqlDataReader DataReader = cmd.ExecuteReader();

            while (DataReader.Read())
            {
                this.patientid = DataReader.GetInt32(0);
                this.forename = DataReader.GetString(1);
                this.surname = DataReader.GetString(2);
                this.gender = DataReader.GetString(3);
                this.dob = DataReader.GetString(4);
                this.email = DataReader.GetString(5);
                this.phonenumber = DataReader.GetString(6);
                this.addressline1 = DataReader.GetString(7);
                this.addressline2 = DataReader.GetString(8);
                this.addressline3 = DataReader.GetString(9);
                this.postcode = DataReader.GetString(10);

            }
            DataReader.Close();
        }
        #endregion
    }

}
