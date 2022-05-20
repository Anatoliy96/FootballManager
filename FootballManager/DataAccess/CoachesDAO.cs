using FootballManager.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.DataAccess
{
    class CoachesDAO
    {
        public List<Coaches> GetCoaches()
        {
            DataBaseCommand com = new DataBaseCommand();
            com.SetCommand("select * from coaches");
            MySqlDataReader DR = com.ExecuteReader();

            List<Coaches> coaches = new List<Coaches>();

            while (DR.Read())
            {
                coaches.Add(
                    new Coaches
                    {
                        FirstName = (string)DR["firstname"],
                        LastName = (string)DR["lastname"],
                        BirthDate = (DateTime)DR["birthdate"],
                        Type = (string)DR["type"],
                        TeamID = (Int32)DR["teamid"]
                    });
            }
            DR.Close();
            return coaches;
        }

        public Coaches GetCoach(int ID)
        {
            DataBaseCommand com = new DataBaseCommand();
            com.SetCommand($"select from players where coachesid = {ID}");
            MySqlDataReader DR = com.ExecuteReader();
            com.OpenConnection();
            Coaches coach = new Coaches();

            if (DR.Read())
            {
                coach.FirstName = (string)DR["firstname"];
                coach.LastName = (string)DR["lastname"];
                coach.BirthDate = (DateTime)DR["birthdate"];
                coach.Type = (string)DR["type"];
                coach.TeamID = (Int32)DR["teamid"];
                com.CloseConnection();
                return coach;
            }
            else
            {
                com.CloseConnection();
                return null;
            }
        }
        
        public DataAccessResponse InsertCoaches(Coaches NewCoach)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("Insert into coaches (firstname, lastname, type, birthdate, teamid) value ('" + NewCoach.FirstName + "', '"
                    + NewCoach.LastName + "' , '" + NewCoach.Type + "', '" + NewCoach.BirthDate.ToString("yyyy-MM-dd")
                    + "' , '" + NewCoach.TeamID + "')");
                com.OpenConnection();
                com.ExecuteNonQuery();
                com.CloseConnection();

                return new DataAccessResponse(true, null);
            }
            catch (Exception ex)
            {
                return new DataAccessResponse(false,ex.Message);
            }
           
        }

        public DataAccessResponse UpdateCoaches(Coaches CurrentCoach)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("Update coaches set" +
                    "firstname = '" + CurrentCoach.FirstName + "', '" +
                    "lastname = '" + CurrentCoach.LastName + "', '" +
                    "birthdate = '" + CurrentCoach.BirthDate.ToString("yyyy-MM-dd") + "', '" +
                    "type = '" + CurrentCoach.Type + "', '" +
                    "teamid = '" + CurrentCoach.TeamID + "' , '" +
                    "where coachid = '" + CurrentCoach.CoachID + "')");

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

        public DataAccessResponse DeleteCoach(Coaches selectedCoach)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("delete from coaches where coachid =" + selectedCoach.CoachID);
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
