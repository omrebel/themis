using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Themis.Classes
{
    class DbConnect
    {
        public static MySqlConnection dbConnect()
        {
            string conStr = ConfigurationManager.ConnectionStrings["Themis.Properties.Settings.MySQL"].ConnectionString;
            MySqlConnection conDatabase = new MySqlConnection(conStr);
            conDatabase.Open();
            return conDatabase;
        }

        public static void dbClose()
        {
            string conStr = ConfigurationManager.ConnectionStrings["Themis.Properties.Settings.MySQL"].ConnectionString;
            using (MySqlConnection conDatabase = new MySqlConnection(conStr))
            {
                conDatabase.Close();
            }
        }
    }
}
