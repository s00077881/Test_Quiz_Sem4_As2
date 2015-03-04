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
                string[] readFile = File.ReadAllLines(Server.MapPath("Nationalities.txt"));

                for (int i = 0; i < readFile.Length; i++)
                {
                    lstNationalities.Items.Add(new ListItem(readFile[i], readFile[i]));
                }

                if (Request.Cookies["user"] != null)
                {
                    tbxFName.Text = Request.Cookies["user"]["Firstname"];
                    tbxLName.Text = Request.Cookies["user"]["Lastname"];
                    tbxEmail.Text = Request.Cookies["user"]["Email"];
                    lstNationalities.SelectedValue = Request.Cookies["user"]["Nationality"];
                }
            }
        }

        protected void btnChoose_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (chkRemember.Checked)
                {
                    HttpCookie user = new HttpCookie("user");
                    user["Firstname"] = tbxFName.Text;
                    user["Lastname"] = tbxLName.Text;
                    user["Email"] = tbxEmail.Text;
                    user["Nationality"] = lstNationalities.SelectedValue;

                    user.Expires = DateTime.Now.AddYears(1);
                    Response.Cookies.Add(user);
                }

                Response.Redirect("quizSelection.aspx");
            }
        }
    }
}