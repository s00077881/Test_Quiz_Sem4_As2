using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Quiz
{
    public partial class question1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<QuizQuestions> questions = (List<QuizQuestions>)Session["questions"];
            testOut.Text = questions.ElementAt(0)._question.ToString();
        }
    }
}