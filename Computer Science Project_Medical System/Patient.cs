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
                this.Forename = dr.GetString(1);
                this.Surname = dr.GetString(2);
            }
            dr.Close();
        }

    }

}
