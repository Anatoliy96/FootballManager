using FootballManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace FootballManager.BusinessLayer.Staff
//{
    //class StaffBLL
    //{
        //public BindingSource GetStaff()
        //{
        //    StaffDAO staff = new StaffDAO();
        //    return new BindingSource(staff.GetAll(), null);
        //}
        //public Model.Response.Response InsertStaff(string FirstName, string LastName, int Age,
        //   DateTime Birthdate, string Position, int ClubID)
        //{
        //    try
        //    {
        //        StaffValidator validator = new StaffValidator();
        //        StaffValidationResponse response = validator.ValidateStaff(FirstName, LastName,Position,
        //            Age, Birthdate, ClubID);

        //        if (response.OK)
        //        {
        //            StaffDAO dao = new StaffDAO();
        //            dao.InsertStaff(new Model.Staff { FirstName = FirstName, LastName = LastName,
        //            Age = Age, Position = Position, })
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
//        }
//    }
//}
