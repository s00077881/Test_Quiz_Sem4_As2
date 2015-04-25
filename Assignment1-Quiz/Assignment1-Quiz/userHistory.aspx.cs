using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Quiz
{
    public partial class userHistory : System.Web.UI.Page
    {
        ProjectDataDataContext db = new ProjectDataDataContext();
        int userId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    var query = from q in db.Quizes
                                select new
                                {
                                    Name = q.Name,
                                    Value = q.Id
                                };

                    foreach (var item in query)
                    {
                        lstQuizzes.Items.Add(new ListItem(item.Name, Convert.ToString(item.Value)));
                    }

                    userId = (int)Session["UserID"];

                    PopulateAllQuizzes();
                }
                else
                    Response.Redirect("login.aspx");
            }
        }

        protected void lstQuizzes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstQuizzes.SelectedIndex != 0)
            {
                userId = (int)Session["UserID"];

                var query = from q in db.Attempts
                             where q.UserID == userId && q.QuizID == Convert.ToInt32(lstQuizzes.SelectedValue)
                             select new
                             {
                                 User = q.User.FirstName + " " + q.User.LastName,
                                 Quiz = q.Quize.Name,
                                 TimeTaken = q.TimeEnd - q.TimeStart,
                                 q.Score
                             };

                gvAttempts.DataSource = query;
                gvAttempts.DataBind();
            }
            else
                PopulateAllQuizzes();
        }

        private void PopulateAllQuizzes()
        {
            userId = (int)Session["UserID"];

            var query = from q in db.Attempts
                         where q.UserID == userId
                         select new
                         {
                             User = q.User.FirstName + " " + q.User.LastName,
                             Quiz = q.Quize.Name,
                             TimeTaken = q.TimeEnd - q.TimeStart,
                             q.Score
                         };

            gvAttempts.DataSource = query;
            gvAttempts.DataBind();
        }
    }
}