using FootballManager.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.DataAccess
{
    class PlayersDAO
    {
        public List<Players> GetPlayers()
        {
            DataBaseCommand com = new DataBaseCommand();
            com.SetCommand("select * from players");
            MySqlDataReader DR = com.ExecuteReader();

            List<Players> players = new List<Players>();

            while (DR.Read())
            {
                players.Add(
                    new Players()
                    {
                        PlayersID = (Int32)DR["playersid"],
                        FirstName = (string)DR["firstname"],
                        LastName = (string)DR["lastname"],
                        BirthDate = (DateTime)DR["birthdate"],
                        Position = (string)DR["position"],
                        Age = (Int32)DR["age"],
                        Weight = (Int32)DR["weight"],
                        Height = (Int32)DR["height"],
                        TeamID = (Int32)DR["teamid"]
                    });
            }
            DR.Close();
            return players;
        }

        public Players GetPlayer(int ID)
        {
            DataBaseCommand com = new DataBaseCommand();
            com.SetCommand($"select * from players where playersid = {ID}");
            com.OpenConnection();
            MySqlDataReader DR = com.ExecuteReader();

            Players players = new Players();

            if (DR.Read())
            {
                players.FirstName = (string)DR["firstname"];
                players.LastName = (string)DR["lastname"];
                players.BirthDate = (DateTime)DR["birthdate"];
                players.Position = (string)DR["position"];
                players.Age = (Int32)DR["age"];
                players.Weight = (Int32)DR["weight"];
                players.Height = (Int32)DR["height"];
                players.TeamID = (Int32)DR["teamid"];

                DR.Close();
                com.CloseConnection();
                return players;
            }
            else
            {
                com.CloseConnection();
                return null;
            }
        }

        public DataAccessResponse InsertPlayer(Players NewPlayer)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("insert into players (firstname, lastname, birthdate, position, age, weight, height, teamid) values ('" +
                    NewPlayer.FirstName + "', '" + NewPlayer.LastName + "', '" + NewPlayer.BirthDate.ToString("yyyy-MM-dd") + "', '" +
                    NewPlayer.Position + "', '" + NewPlayer.Age + "', '" + NewPlayer.Weight + "', '" + NewPlayer.Height + "', '" +
                    NewPlayer.TeamID + "')");
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

        public DataAccessResponse UpdatePlayer(Players CurrentPlayer)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("Update players set " +
                    "firstname = '" + CurrentPlayer.FirstName + "', " +
                    "lastname = '" + CurrentPlayer.LastName + "', " +
                    "birthdate = '" + CurrentPlayer.BirthDate.ToString("yyyy-MM-dd") + "', " +
                    "position = '" + CurrentPlayer.Position + "', " +
                    "age = '" + CurrentPlayer.Age + "', " +
                    "weight = '" + CurrentPlayer.Weight + "', " +
                    "height = '" + CurrentPlayer.Height + "', " +
                    "teamid = '" + CurrentPlayer.TeamID + "' " +
                    "where playersid = " + CurrentPlayer.PlayersID);

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

        public DataAccessResponse DeletePlayer(Players SelectedPlayer)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("delete from players where playersid = " + SelectedPlayer.PlayersID);
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
