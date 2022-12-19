using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Online_School_Management_System.Models
{
    public class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private string ConStr;
        private SqlDataAdapter sda;

        public Functions()
        {
            ConStr = "Data Source=THILANKA;Initial Catalog=OnlineSchoolDB;Integrated Security=True";
            con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public int SetData(string Query)
        {
            int cnt = 0;
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText=Query;
            cnt =cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }

        public DataTable GetData(string Query)
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(Query, con);
            sda.Fill(dt);
            return dt;
         }


    }
}