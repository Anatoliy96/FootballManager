using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Model;
using MySql.Data.MySqlClient;

namespace FootballManager.DataAccess
{
    public class ClubDAO
    {
        public List<Club> GetClubs()
        {
            DataBaseCommand com = new DataBaseCommand();
            com.SetCommand("select * from clubs");
            MySqlDataReader DR = com.ExecuteReader();

            List<Club> clubs = new List<Club>();

            while (DR.Read())
            {
                clubs.Add(
                    new Club()
                    {
                        ClubsID = (Int32)DR["clubsid"],
                        Name = (string)DR["name"],
                        Owner = (string)DR["owner"],
                        Founded = (DateTime)DR["founded"]
                     
                    }
                    );
            }
            DR.Close();
            return clubs;
        }

        public Club GetClub(int ID)
        {
            DataBaseCommand comm = new DataBaseCommand();
            comm.SetCommand($"select * from clubs where clubsid = {ID}");
            comm.OpenConnection();
            MySqlDataReader DR = comm.ExecuteReader();
            Club club = new Club();
            if (DR.Read())
            {
                club.Name = DR["name"].ToString();
                club.Owner = DR["owner"].ToString();
                club.Founded = (DateTime)DR["founded"];
                DR.Close();
                comm.CloseConnection();

                return club;
            }
            else
            {
                comm.CloseConnection();

                return null;
            }
            

        }
        public DataAccessResponse InsertClub(Club NewClub)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("insert into clubs (name, owner, founded) values ('" + NewClub.Name + "', '" +
                    NewClub.Owner + "', '" + NewClub.Founded.ToString("yyyy-MM-dd") + "')");
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

        public DataAccessResponse UpdateClub(Club CurrentClub)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("Update clubs set " +
                    "name = '" + CurrentClub.Name + "', " +
                    "owner = '" + CurrentClub.Owner + "', " +
                    "founded = '" + CurrentClub.Founded.ToString("yyyy-MM-dd") + "' " +
                    "where clubsid = " + CurrentClub.ClubsID);
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


        public DataAccessResponse DeleteClub(Club selectedClub)
        {
            try
            {
                DataBaseCommand com = new DataBaseCommand();
                com.SetCommand("delete from clubs where clubsid = " + selectedClub.ClubsID);
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
