using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Quiz
{
    public partial class login : System.Web.UI.Page
    {
        //Main link to database
        ProjectDataDataContext db = new ProjectDataDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Check if cookie exists // if(true) populate relivent input fields
                if (Request.Cookies["s00147036/s00077881"] != null)
                {
                    tbxFName.Text = Request.Cookies["s00147036/s00077881"]["Firstname"];
                    tbxLName.Text = Request.Cookies["s00147036/s00077881"]["Lastname"];
                    tbxEmail.Text = Request.Cookies["s00147036/s00077881"]["Email"];
                    lstNationalities.SelectedIndex = Convert.ToInt32(Request.Cookies["s00147036/s00077881"]["Nationality"]);
                }
            }
        }


        /***********************************************************************
         * On butten click if(valid) create new cookie and store user information
         * Check if Remember me checked
         * Add 1 year to todays date
         * Store new date with cookie
         * Redirect to quizSelection page
         ***********************************************************************/


        protected void btnChoose_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string fName = tbxFName.Text;
                string lName = tbxLName.Text;
                string email = tbxEmail.Text;
                int nation = lstNationalities.SelectedIndex;

                var userId = from u in db.Users
                             where email == u.Email
                             select u.UserID.ToString();

                if (userId.Count() == 0)
                {
                    //Add New user to database
                    User newUser = new User
                    {
                        FirstName = fName,
                        LastName = lName,
                        Email = email,
                        NationalityID = nation
                    };

                    try
                    {
                        db.Users.InsertOnSubmit(newUser);
                    }
                    catch (Exception ex)
                    {
                        //Populate error message
                    }

                    db.SubmitChanges();
                }
                
                //Add user to Cookie
                if (chkRemember.Checked)
                {
                    HttpCookie user = new HttpCookie("s00147036/s00077881");

                    user["Firstname"] = fName;
                    user["Lastname"] = lName;
                    user["Email"] = email;
                    user["Nationality"] = nation.ToString();
                    
                    user.Expires = DateTime.Now.AddYears(1);
                    Response.Cookies.Add(user);
                }
                else
                {
                    //Delete cookie if user unticks box and submits form
                    HttpCookie user = new HttpCookie("s00147036/s00077881");
                    user.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(user);
                }

                Session.Add("UserID", userId);

                Response.Redirect("quizSelection.aspx");
            }
        }
    }
}