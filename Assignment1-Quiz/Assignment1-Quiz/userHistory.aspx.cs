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

        public string dataPoints;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    try
                    {
                        //Pull out the Name and ID of the quizzes from
                        //the quiz table to populatethe dropdown list
                        //with the ID as the value
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

                        PopulateUserLabel();
                        PopulateAllQuizzes();
                    }
                    catch(Exception ex)
                    {
                        lblDbErrorNotice.Text = "Internal Server Error. Error Message: " + ex.Message + ". Please Contact the Site Administrator.";
                    }
                }
                else
                    Response.Redirect("login.aspx");
            }
        }

        protected void lstQuizzes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If 'All Quizzes' is selected jump to PopulateAllQuizzes() method
            //Else populate grid view with quizzes relvant to the choosen quiz id
            if (lstQuizzes.SelectedIndex != 0)
            {
                userId = (int)Session["UserID"];

                try
                {
                    /******************************************************************
                    * Pull out the quiz name, date taken, time taken 
                    * and score from attempts for that user and quiz
                    * 
                    * Use this info to fill the drigview and the populate the chart
                    *******************************************************************/
                    var query = from q in db.Attempts
                                where q.UserID == userId && q.QuizID == Convert.ToInt32(lstQuizzes.SelectedValue)
                                orderby q.TimeEnd descending
                                select new
                                {
                                    Quiz = q.Quize.Name,
                                    Date = q.TimeEnd,
                                    TimeTaken = String.Format("{0:hh\\:mm\\:ss}", q.TimeEnd - q.TimeStart),
                                    Score = q.Score
                                };

                    gvAttempts.DataSource = query;
                    gvAttempts.DataBind();

                    PopulateChart();
                }
                catch (Exception ex)
                {
                    lblDbErrorNotice.Text = "Internal Server Error. Error Message: " + ex.Message + ". Please Contact the Site Administrator.";
                }
            }
            else
                PopulateAllQuizzes();
        }

        private void PopulateUserLabel()
        {
            try
            {
                //Pull out the first and last name of
                //the user (UserID == userId)
                var query = (from q in db.Users
                             where q.UserID == userId
                             select new
                             {
                                 UserName = q.FirstName + " " + q.LastName
                             }).First();

                lblDisplayUser.Text = "Displaying previous attempts for " + query.UserName;
            }
            catch (Exception ex)
            {
                lblDbErrorNotice.Text = "Internal Server Error. Error Message: " + ex.Message + ". Please Contact the Site Administrator.";
            }
        }

        private void PopulateAllQuizzes()
        {
            /***************************************
             * Fill gridview with all attempts for 
             * that user
             * *************************************/
            userId = (int)Session["UserID"];

            try
            {
                var query = from q in db.Attempts
                            where q.UserID == userId
                            orderby q.TimeEnd descending
                            select new
                            {
                                Quiz = q.Quize.Name,
                                Date = Convert.ToDateTime(q.TimeEnd),
                                TimeTaken = String.Format("{0:hh\\:mm\\:ss}", q.TimeEnd - q.TimeStart),
                                Score = q.Score
                            };

                gvAttempts.DataSource = query;
                gvAttempts.DataBind();

                PopulateChart();
            }
            catch (Exception ex)
            {
                lblDbErrorNotice.Text = "Internal Server Error. Error Message: " + ex.Message + ". Please Contact the Site Administrator.";
            }
        }

        private void PopulateChart()
        {
            /**********************************************
             * Pull out each score from the attempts table
             * for the user.
             * 
             * If a specific quiz is selected from the dropdown,
             * Pull out just scores for that quiz
             * 
             * Concatenate each score into a public string variable
             * (dataPoints) to be used by the javascript
             * ********************************************/
            if (lstQuizzes.SelectedIndex != 0)
            {
                var query = from q in db.Attempts
                            where q.UserID == userId && q.QuizID == Convert.ToInt32(lstQuizzes.SelectedValue)
                            orderby q.TimeEnd descending
                            select new
                            {
                                Score = q.Score
                            };

                foreach (var item in query)
                {
                    dataPoints += "{ y: " + item.Score + " },";
                }
            }
            else
            {
                var query = from q in db.Attempts
                            where q.UserID == userId
                            orderby q.TimeEnd descending
                            select new
                            {
                                Score = q.Score
                            };

                foreach (var item in query)
                {
                    dataPoints += "{ y: " + item.Score + " },";
                }
            }
        }

        protected void btnQuizSelect_Click(object sender, EventArgs e)
        {
            Session.Remove("answers");
            Response.Redirect("quizSelection.aspx");
        }
    }
}