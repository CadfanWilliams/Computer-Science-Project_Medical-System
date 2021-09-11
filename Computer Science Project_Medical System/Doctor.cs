using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Computer_Science_Project_Medical_System
{
    class Doctor
    {
        //Connection to database
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS01;Database=Medical System;Trusted_Connection=True;");
        //
        //Fields
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
        //
        //Constructors
        public Doctor(int userid)
        {
            this.Userid = userid;
            
        }
        //
        //properties
        //
        //methods

        
        public void getDoctorDetails()
        {
            //Get details of the doctor
        }
    }
}
