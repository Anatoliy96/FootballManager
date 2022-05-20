using FootballManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballManager.BusinessLayer.Clubs;
using FootballManager.Model;

namespace FootballManager.BusinessLayer
{
    public class ClubBLL
    {
        public BindingSource GetClubs()
        {
            ClubDAO dao = new ClubDAO();
            return new BindingSource(dao.GetClubs(), null);
        }

        public Model.Response.Response InsertClub(string Name, string Owner, DateTime Founded)
        {
            try
            {
                ClubValidator validator = new ClubValidator();
                ClubValidationResponse response = validator.ValidateNewClub(Name, Owner);
                if (response.OK)
                {
                    ClubDAO club = new ClubDAO();
                    club.InsertClub(new Model.Club() { Name = Name, Owner = Owner, Founded = Founded });

                    MessageBox.Show("Club Inserted");
                }
                return response;
            }
            catch(Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }

        public Model.Response.Response UpdateClub(string Name, string Owner, DateTime Founded, string OldName)
        {
            try
            {
                ClubValidator validator = new ClubValidator();
                ClubValidationResponse response = validator.UpdateCurrentClub(Name, Owner, Founded);
                if (response.OK)
                {
                    
                    ClubDAO club = new ClubDAO();
                    int clubsid = club.GetClubs().FirstOrDefault(c => c.Name == OldName).ClubsID;
                    club.UpdateClub(new Model.Club() { Name = Name, Owner = Owner, Founded = Founded, ClubsID = clubsid});

                    MessageBox.Show("Player Updated");
                }

                return response;
            }
            catch (Exception ex)
            {
                return new DataAccessResponse(false, ex.Message);
            }
        }

        public Model.Response.Response DeleteClub(int ClubsID)
        {
            try
            {
                ClubValidator validator = new ClubValidator();
                ClubValidationResponse response = validator.DeleteClub(ClubsID);
                if (response.OK)
                {
                    ClubDAO club = new ClubDAO();
                    int clubsid = club.GetClubs().FirstOrDefault(c => c.ClubsID == ClubsID).ClubsID;
                    club.DeleteClub(new Club() { ClubsID = clubsid });
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
