using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClockWithSql
{
    internal class DBConnection
    {
        static SqlConnection sqlConnection;
        static string connectionString = "server = SHALOM\\SQLSERVER;initial catalog=time_clock1; user id=sa; password=1234;TrustServerCertificate=Yes";
        public static bool Connect()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static string runSQLAlllResult(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlDataAdapter cmd = new SqlDataAdapter();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {

                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }


                    object SqlDataAdapter = cmd.();
                    return result.ToString();
                }
        }
/*עדכונים*/
        public static string runSQLLnoResult(string sql, string[] parameters = null, string[] values = null)
        {

        }
        public static string runSQLScalarSingelResult(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {   
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {

                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                   

                    object result = cmd.ExecuteScalar();
                    return result.ToString();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            return "";
        }
    }
}
