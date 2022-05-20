using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FootballManager.DataAccess
{
    public class DataBaseCommand
    {
        MySqlCommand com;
        public DataBaseCommand()
        {
            com = new MySqlCommand("", ConnectionSingleton.GetConnection());
        }

        public void SetCommand(string command)
        {
            com.CommandText = command;
        }

        public void OpenConnection()
        {
            if (com.Connection.State == System.Data.ConnectionState.Closed)
            {
                com.Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (com.Connection.State == System.Data.ConnectionState.Open)
            {
                com.Connection.Close();
            }
        }


        public MySqlDataReader ExecuteReader()
        {
            OpenConnection();
            return com.ExecuteReader();
        }

        /// <summary>
        /// For Insert Update and Delete
        /// </summary>
        /// <returns></returns>
        public int ExecuteNonQuery()
        {
            OpenConnection();
            return com.ExecuteNonQuery();
        }
    }
}
