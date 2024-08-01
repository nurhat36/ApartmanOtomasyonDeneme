using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanOtomasyonDeneme
{
    

    class SQLHelper
    {
        private string ConnectionString {  get; set; }
        public SqlConnection Connection {  get; set; }
        public SQLHelper()
        {
            ConnectionString = "Data Source=DESKTOP-T11FMIO;Initial Catalog=APARTMAN;Integrated Security=True;TrustServerCertificate=True";
            Connection=new SqlConnection(ConnectionString);
           

        }
        public void ExecuteProc(string ProcName, params SqlParameter[] ps)
        {
            SqlCommand command=new SqlCommand();
            command.CommandType=CommandType.StoredProcedure;
            command.CommandText=ProcName;
            command.Parameters.AddRange(ps);
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable GetDataTable(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query,ConnectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
    }
}
