using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace Computer_Science_Project_Medical_System
{
    class Patient
    {
        //Connection to database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


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
        public int userid;
        

        //Constructors

        public Patient(int userid)
        {
            this.Userid = userid;

            getDetails();

            
        }
        public Patient()
        {
            this.Userid = 3;

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
            string login = "SELECT * FROM tbl_patients WHERE userid = '" + Userid + "'";
            cmd = new OleDbCommand(login, con);

            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                this.patientid = dr.GetInt32(0);
                this.forename = dr.GetString(1);
                this.surname = dr.GetString(2);
                this.gender = dr.GetString(3);
                this.dob = dr.GetDateTime(4).ToShortDateString();
                this.email = dr.GetString(5);
                this.phonenumber = dr.GetString(6);
                this.addressline1 = dr.GetString(7);
                this.addressline2 = dr.GetString(8);
                this.addressline3 = dr.GetString(9);
                this.postcode = dr.GetString(10);

            }
            dr.Close();
        }

    }

}
