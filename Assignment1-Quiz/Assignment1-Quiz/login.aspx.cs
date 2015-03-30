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
                    lstNationalities.SelectedValue = Request.Cookies["s00147036/s00077881"]["Nationality"];
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
                if (chkRemember.Checked)
                {
                    HttpCookie user = new HttpCookie("s00147036/s00077881");
                    user["Firstname"] = tbxFName.Text;
                    user["Lastname"] = tbxLName.Text;
                    user["Email"] = tbxEmail.Text;
                    user["Nationality"] = lstNationalities.SelectedValue;

                    user.Expires = DateTime.Now.AddYears(1);
                    Response.Cookies.Add(user);
                }
                else
                {
                    HttpCookie user = new HttpCookie("s00147036/s00077881");
                    user.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(user);
                }

                Response.Redirect("quizSelection.aspx");
            }
        }
    }
}