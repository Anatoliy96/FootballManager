using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Model;
using MySql.Data.MySqlClient;

namespace FootballManager.DataAccess
{
    public class TeamsDAO
    {
        public List<Teams> GetTeams()
        {
            DataBaseCommand com = new DataBaseCommand();
            com.SetCommand("select * from teams");
            MySqlDataReader DR = com.ExecuteReader();

            List<Teams> teams = new List<Teams>();

            while (DR.Read())
            {
                teams.Add(
                    new Teams()
                    {
                        TeamsID = (Int32)DR["teamsid"],
                        Name = (string)DR["name"],
                        ClubID = (Int32)DR["clubid"]
                    }
                    );
            }
            DR.Close();
            return teams;
        }

        public Teams GetTeam(int ID)
        {
            DataBaseCommand com = new DataBaseCommand();
            com.SetCommand($"select * from teams where teamsid = {ID}");
            MySqlDataReader DR = com.ExecuteReader();
            Teams teams = new Teams();

            if (DR.Read())
            {
                teams.Name = DR["name"].ToString();
                teams.ClubID = (Int32)DR["clubid"];

                DR.Close();
                com.CloseConnection();

                return teams;
            }
            
            else
            {
                com.CloseConnection();

                return null;
            }
        }

        public DataAccessResponse InsertTeam(Teams team)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("insert into teams (name, clubid) values ('" + team.Name + "', '" + team.ClubID + "')");
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

        public DataAccessResponse UpdateTeam(Teams CurrenTeam)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("Update teams set" +
                    "name = '" + CurrenTeam.Name + ",'" +
                    "where teamsid = " + CurrenTeam.TeamsID);

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

        public DataAccessResponse DeleteTeam(Teams SelectedTeam)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("delete from teams where teamsid = " + SelectedTeam.TeamsID);
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
