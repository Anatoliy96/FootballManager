using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.DataAccess;
using System.Windows.Forms;
using FootballManager.Model;

namespace FootballManager.BusinessLayer
{
    public class TeamsBLL
    {
        public BindingSource GetTeams()
        {
            TeamsDAO team = new TeamsDAO();
            return new BindingSource(team.GetTeams(), null);
        }

        public Model.Response.Response InsertTeam(string Name, int ClubID)
        {
            try
            {
                TeamValidator validator = new TeamValidator();
                TeamValidationResponse response = validator.ValidateTeam(Name);
                if (response.OK)
                {
                    TeamsDAO teams = new TeamsDAO();
                    teams.InsertTeam(new Model.Teams() { Name = Name, ClubID = ClubID });

                    MessageBox.Show("Team Inserted");
                }
                return response;
            }
            catch (Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }

        public Model.Response.Response UpdateTeam(string Name, string oldName)
        {
            try
            {
                TeamValidator validator = new TeamValidator();
                TeamValidationResponse response = validator.ValidateTeam(Name);
                if (response.OK)
                {
                    TeamsDAO teams = new TeamsDAO();
                    int teamsid = teams.GetTeams().FirstOrDefault(t => t.Name == oldName).TeamsID;
                    teams.UpdateTeam(new Model.Teams() { Name = Name, TeamsID = teamsid });

                    MessageBox.Show("Team Updated");
                }
                return response;
            }
            catch (Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }

        public Model.Response.Response DeleteTeam(int TeamsID)
        {
            try
            {
                TeamValidator validator = new TeamValidator();
                TeamValidationResponse response = validator.DeleteTeam(TeamsID);

                if (response.OK)
                {
                    TeamsDAO teams = new TeamsDAO();
                    int teamsid = teams.GetTeams().FirstOrDefault(t => t.TeamsID == TeamsID).TeamsID;
                    teams.DeleteTeam(new Teams() { TeamsID = teamsid });
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
