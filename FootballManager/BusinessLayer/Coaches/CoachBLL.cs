using FootballManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManager.BusinessLayer.Coaches
{
    public class CoachBLL
    {
        public BindingSource GetCoaches()
        {
            CoachesDAO coach = new CoachesDAO();
            return new BindingSource(coach.GetCoaches(), null);
        }
        public Model.Response.Response InsertCoaches(string FirstName, string LastName, string Type, DateTime Birthdate,
            int TeamID)
        {
            try
            {
                CoachValidator validator = new CoachValidator();
                CoachValidationResponse response = validator.ValidateCoach(FirstName, LastName, Type, Birthdate, TeamID);
                if (response.OK)
                {
                    CoachesDAO dao = new CoachesDAO();
                    dao.InsertCoaches(new Model.Coaches()
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        BirthDate = Birthdate,
                        Type = Type,
                        TeamID = TeamID
                    });
                    MessageBox.Show("Coach inserted");
                }
                return response;
            }
            catch (Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }

        public Model.Response.Response UpdateCoach(string FistName, string LastName, string Type, DateTime BirthDate,
            int TeamID , string oldName)
        {
            try
            {
                CoachValidator validator = new CoachValidator();
                CoachValidationResponse response = validator.ValidateCoach(FistName, LastName, Type, BirthDate, TeamID);
                if (response.OK)
                {
                    CoachesDAO dao = new CoachesDAO();
                    int coachid = dao.GetCoaches().FirstOrDefault(c => c.FirstName == oldName).CoachID;
                    dao.UpdateCoaches(new Model.Coaches()
                    {
                        FirstName = FistName,
                        LastName = LastName,
                        BirthDate = BirthDate,
                        Type = Type,
                        TeamID = TeamID
                    });
                    MessageBox.Show("Coach Updated");
                }
                return response;
            }
            catch (Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }

        public Model.Response.Response DeleteCoach(int CoachID)
        {
            try
            {
                CoachValidator validator = new CoachValidator();
                CoachValidationResponse response = validator.DeleteCoach(CoachID);
                if (response.OK)
                {
                    CoachesDAO dao = new CoachesDAO();
                    int coachid = dao.GetCoaches().FirstOrDefault(c => c.CoachID == CoachID).CoachID;
                    dao.DeleteCoach(new Model.Coaches() { CoachID = CoachID });

                    MessageBox.Show("Coach Deleted");
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
