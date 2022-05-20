using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FootballManager.DataAccess
{
    class ConnectionSingleton
    {
        private static MySqlConnection con = null;
        protected ConnectionSingleton()
        {

        }

        public static MySqlConnection GetConnection()
        {
            if (con == null)
            {
                con = new MySqlConnection("Server=localhost;Database=uefabet;Uid=root;Pwd=root;");
            }

            return con;
        }

        public static void Open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
