using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Computer_Science_Project_Medical_System
{
    class Patient
    {
        //Connection to database
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS01;Database=Medical System;Trusted_Connection=True;");

        // Fields
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
 
        //Constructors

        public Patient(int userid)
        {
            this.Userid = userid;

            getDetails();

            
        }
        //Properties

        public string Forename
        { get; set; }
        public string Surname
        { get; set; }
        public int Userid
        { get; set; }

        //Methods
        public void getDetails()
        {
            //SQL Commands
            string Query = "SELECT * FROM tbl_patients WHERE userid = '" + Userid + "'";
            SqlCommand cmd = new SqlCommand(Query, con);

            con.Open();
            SqlDataReader DataReader = cmd.ExecuteReader();
            
            while (DataReader.Read())
            {
                this.patientid = DataReader.GetInt32(0);
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

            }
            DataReader.Close();
        }

    }

}
