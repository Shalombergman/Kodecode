using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace host
{
    internal class HostController
    {
        public static List<string>GetCategories()
        {
            string sql = "select * from Categories";
                
            // Add items to the ListBox
            SqlDataReader categoriesReader = DBconnection.RunSqlAllResult(sql);
            List<string> categories = new List<string>();
            for (int i = 0; categoriesReader.Read();i++)
            {
                categories.Add(categoriesReader.GetString(1));
            }
            categoriesReader.Close();   
            return categories;
        }
        public static List<string> searchcategorybyname(string categories_name)
        {
            
            string sql = "select * from categories where categories_name like '%'+@filter+'%'";
            string[] parameters = { "@filter" };
            string[] values = { categories_name };
            SqlDataReader categoriesReader = DBconnection.RunSqlAllResult(sql, parameters, values);
            List<string> categories = new List<string>();
            for (int i = 0; categoriesReader.Read(); i++)
            {
                categories.Add(categoriesReader.GetString(1));
            }
            categoriesReader.Close();
            return categories;
        }
        public static DataTable selectRows( string labCategorey)
        {
            string sql = "select food.food_name as food_name , count( food.food_name) as quality from food\r\n--מוסיפים את טבלת קטגוריות ונשווה שמות\r\njoin Categories on Categories.Categorise_id = food.categories_id\r\nwhere @categorey__name = Categories.categories_name\r\n--נצמצם את התשובות באמצעות\r\ngroup by food.food_name";
            string[] parameters = { "@categorey__name" };
            string[] values = { labCategorey };
            DataTable categoriesAdapter = DBconnection.RunSqlTableResult(sql, parameters, values);
            return categoriesAdapter;



        }
        public static void addCategory(string category)
        {
            string sql = "select categories_name from Categories\\r\\n--בדיקה האם המשתנה שווה לאחת הקטגוריות\\r\\nwhere categories_name = @categories_name\\r\\n\\r\\n\\tbegin\\r\\n\\t--הכנסת הקטגוריה לטבלה\\r\\n\\t\\tinsert into Categories(categories_name) values( @categories_name)\\r\\n\\tend";
            string[] parameters = { "@categories_name" };
            string[] values = { category };
            DBconnection.RunSqlNoReturn(sql, parameters, values);
        }
    }
}
