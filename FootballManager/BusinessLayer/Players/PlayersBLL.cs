using FootballManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManager.BusinessLayer
{
    class PlayersBLL
    {
        public BindingSource GetPlayers()
        {
            PlayersDAO players = new PlayersDAO();
            return new BindingSource(players.GetPlayers(), null);
        }

        public Model.Response.Response InsertPlayers(string FirstName, string LastName, DateTime BirthDate,
            string Position, int Age, int Weight, int Height, int TeamID)
        {
            try
            {
                PlayerValidator validator = new PlayerValidator();
                PlayerValidationResponse response = validator.ValidatePlayer(FirstName, LastName, Position, Age, Weight, Height, TeamID);

                if (response.OK)
                {
                    PlayersDAO playersDAO = new PlayersDAO();
                    playersDAO.InsertPlayer(new Model.Players()
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        BirthDate = BirthDate,
                        Position = Position,
                        Age = Age,
                        Weight = Weight,
                        Height = Height,
                        TeamID = TeamID
                    });

                    MessageBox.Show("Player Inserted");
                }
                return response;
            }

            catch (Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }

        public Model.Response.Response UpdatePlayer(string FirstName, string LastName, DateTime BirthDate, string Position,
            int Age, int Weight, int Height, int TeamID, string OldName)
        {
            try
            {
                PlayerValidator validator = new PlayerValidator();
                PlayerValidationResponse response = validator.ValidatePlayer(FirstName, LastName, Position, Age,
                    Weight, Height, TeamID);

                if (response.OK)
                {
                    PlayersDAO players = new PlayersDAO();
                    int playersid = players.GetPlayers().FirstOrDefault(p => p.FirstName == OldName).PlayersID;
                    players.UpdatePlayer(new Model.Players()
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        BirthDate = BirthDate,
                        Position = Position,
                        Age = Age,
                        Weight = Weight,
                        Height = Height,
                        TeamID = TeamID,
                        PlayersID = playersid
                    });
                    MessageBox.Show("Player Updated");
                    
                }
                    return response;
            }
            catch (Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }

        public Model.Response.Response DeletePlayer(int PlayersID)
        {
            try
            {
                PlayerValidator validator = new PlayerValidator();
                PlayerValidationResponse response = validator.DeletePlayer(PlayersID);

                if (response.OK)
                {
                    PlayersDAO players = new PlayersDAO();
                    int playerid = players.GetPlayers().FirstOrDefault(p => p.PlayersID == PlayersID).PlayersID;
                    players.DeletePlayer(new Model.Players() { PlayersID = playerid });
                }
                return response;
            }
            catch (Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }
    }
}
