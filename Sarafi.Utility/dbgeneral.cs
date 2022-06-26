using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sarafi.Utility
{
    public  class dbgeneral
    {
        SqlConnection conn = new SqlConnection(SD.GetConnection);

        public  int GetMaxID(string tablename, string columnname)
        {
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT isnull(max(replace(" + columnname + ",'ID','')),0)+1 ID FROM " + tablename + "";
            conn.Open();
            int maxid = (int)cmd.ExecuteScalar();
            conn.Close();
            return maxid;
        }


         public DataTable Selectdb(string storedprocedure,SqlParameter[] par)
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(storedprocedure,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(SqlParameter p in par)
                {
                    cmd.Parameters.Add(p);
                }
                conn.Close();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }

    }
}
