using FootballManager.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.DataAccess
{
    class StaffDAO
    {
        public List<Staff> GetAll()
        {
            DataBaseCommand com = new DataBaseCommand();
            com.SetCommand("select * from staff");
            MySqlDataReader DR = com.ExecuteReader();

            List<Staff> staff = new List<Staff>();

            while (DR.Read())
            {
                staff.Add(
                    new Staff()
                    {
                        StaffID = (Int32)DR["staffid"],
                        FirstName = (string)DR["firstname"],
                        LastName = (string)DR["lastname"],
                        Age = (Int32)DR["age"],
                        Position = (string)DR["position"],
                        ClubID = (Int32)DR["clubid"]
                    });
            }
            DR.Close();
            return staff;
        }

        public Staff GetStaff(int ID)
        {
            DataBaseCommand com = new DataBaseCommand();
            com.SetCommand($"select * from staff where staffid = { ID }");
            com.OpenConnection();
            MySqlDataReader DR = com.ExecuteReader();

            Staff staff = new Staff();
            if (DR.Read())
            {
                staff.FirstName = (string)DR["firstname"];
                staff.LastName = (string)DR["lastname"];
                staff.Age = (Int32)DR["age"];
                staff.Position = (string)DR["position"];
                staff.ClubID = (Int32)DR["clubid"];

                DR.Close();
                com.CloseConnection();
                return staff;
            }
            else
            {
                com.CloseConnection();
                return null;
            }
        }

        public DataAccessResponse InsertStaff(Staff newStaff)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("insert into staff(firstname,lastname,age,position,clubid) values ('" + newStaff.FirstName + "', '" +
                   newStaff.LastName + "', '" + newStaff.Age + "', '" + newStaff.Position + "', '" + newStaff.ClubID + "')");
                com.OpenConnection();
                com.ExecuteNonQuery();
                com.CloseConnection();

                return new DataAccessResponse(true, null);
            }
            catch (Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }
    }
}
