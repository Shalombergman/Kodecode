using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guests_and_hosts
{
    internal class GuestContrroller
    {
        public static List<string> GetGuestName()
        {
            string sql = "select * from Guests";

            // Add items to the ListBox
            SqlDataReader guestNameReader = DBconaction.RunSqlAllResult(sql);
            List<string> guestName = new List<string>();
            for (int i = 0; guestNameReader.Read(); i++)
            {
                guestName.Add(guestNameReader.GetString(1));
            }
            guestNameReader.Close();
            return guestName;
        }
        public static List<string> searcheGuestsName(string guests_name)
        {

            string sql = "select * from Guests where Guests_name like '%'+@filter+'%'";
            string[] parameters = { "@filter" };
            string[] values = { guests_name };
            SqlDataReader guestNameReader = DBconaction.RunSqlAllResult(sql, parameters, values);
            List<string> guestName = new List<string>();
            for (int i = 0; guestNameReader.Read(); i++)
            {
                guestName.Add(guestNameReader.GetString(1));
            }
            guestNameReader.Close();
            return guestName;
        }
        public static DataTable selectRowsDidNotChoose(string lablCategorey)
        {
            string sql = "select food.food_name as food_name  ,   count( food.food_name) \r\nfrom food\r\njoin Categories \r\non Categories.Categorise_id = food.categories_id\r\njoin Guests on Guests.Guests_id = food.guests_id\r\nwhere @categorey__name2 = Categories.categories_name \r\nand @gust__name != Guests.Guests_name\r\ngroup by food.food_name";
            string[] parameters = { "@categorey__name2" };
            string[] values = { lablCategorey };
            DataTable guestsNameAdapter = DBconaction.RunSqlTableResult(sql, parameters, values);
            return guestsNameAdapter;



        }
        public static DataTable selectRowsDidChoose(string lablCategorey)
        {
            string sql = "select food.food_name as food_name  ,   count( food.food_name) \r\nfrom food\r\njoin Categories \r\non Categories.Categorise_id = food.categories_id\r\njoin Guests on Guests.Guests_id = food.guests_id\r\nwhere @categorey__name2 = Categories.categories_name \r\nand @gust__name = Guests.Guests_name\r\ngroup by food.food_name";
            string[] parameters = { "@categorey__name2" };
            string[] values = { lablCategorey };
            DataTable guestsNameAdapter = DBconaction.RunSqlTableResult(sql, parameters, values);
            return guestsNameAdapter;



        }
        public static void addGuestName(string guestName)
        {
            string sql = "select Guests_name from Guests\r\n\r\nwhere Guests_name = @guest_name\r\n\tbegin\r\n\t--הכנסת אורח לטבלה\r\n\t\tinsert into Guests(Guests_name) values (@guest_name)\r \n end";
            string[] parameters = { "@guest_name" };
            string[] values = { guestName };
            DBconaction.RunSqlNoReturn(sql, parameters, values);
        }
    }
}
