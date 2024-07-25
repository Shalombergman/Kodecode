using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace host
{
    internal class DBconnection
    {
        //משתנה שמחזיק את החיבור
        static SqlConnection sqlConnection;
       // ..משתנה שמחזיק את הכתובת לשרת של הדאטה בייס
        static string connectionString = "server = SHALOM\\SQLSERVER;initial catalog=Shabat; user id=sa; password=1234;TrustServerCertificate=Yes";
        //פומקציה שמבצעת את פתיחת החיבור
        public static bool Connect()
        {
            try
            {
                if (sqlConnection == null)
                {
                    sqlConnection = new SqlConnection(connectionString);
                };
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                return true;
                    

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static Object RunScalarResult(object obj)
        {
            return obj;
        }

        //מחזיר מצביע שעובר על כל שורה בטבלה שאני בתוך השורה אני מחליט לפי איזה עמודה להוציא את הנתונים
        public static SqlDataReader RunSqlAllResult(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {                  
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                 
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }                     
                    }
                    //ערוץ פתוח ך sql
                    
                    return cmd.ExecuteReader();                  
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }return null;           
        }
        //פונקציה שמחזירה טבלת נתונים בזיכרון
        public static DataTable RunSqlTableResult(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }

                    }
                    //
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    //
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return null;

        }
        public static void RunSqlNoReturn(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }

                    }
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
