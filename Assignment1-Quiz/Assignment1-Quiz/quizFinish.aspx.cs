using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_Quiz
{
    public partial class quizFinish : System.Web.UI.Page
    {
        //List<QuizQuestions> questions;
        //List<int> quesAnswered;
        //List<string> answers;
        //public int score = 0;
        //public double average = 0;

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    //Call Methood to show pull results from session and display
        //    if (!IsPostBack)
        //        ShowResult();

        //}

        //protected void ShowResult()
        //{
        //    questions = (List<QuizQuestions>)Session["questions"];
        //    quesAnswered = (List<int>)Session["quesAnswered"];
        //    answers = (List<string>)Session["answers"];

        //    /************************************************************
        //     * If questions or questions answered exists in the session
        //     * Pull the questions and answers
        //     * Determin if answers corect
        //     * Display Results
        //     *
        //     * Read quizes text file
        //     * Add 1 to times taken and new score to total score for quiz
        //     * Calculate average with times taken and total score
        //     * Write new values to text file
        //     ************************************************************/
        //    if (questions != null && quesAnswered != null)
        //    {
        //        DisplayAnswers(0, lblQuestion1, lstAnswers1);
        //        DisplayAnswers(1, lblQuestion2, lstAnswers2);
        //        DisplayAnswers(2, lblQuestion3, lstAnswers3);
        //        DisplayAnswers(3, lblQuestion4, lstAnswers4);
        //        DisplayAnswers(4, lblQuestion5, lstAnswers5);
        //        DisplayAnswers(5, lblQuestion6, lstAnswers6);

        //        List<Quiz> quizzes = new List<Quiz>();

        //        string[] readFile = File.ReadAllLines(Server.MapPath("Quizzes.txt"));
        //        string[] splitLine;

        //        for (int i = 0; i < readFile.Length; i++)
        //        {
        //            splitLine = readFile[i].Split(',');
        //            Quiz newQuiz = new Quiz(splitLine[0], splitLine[1], splitLine[2], Convert.ToInt32(splitLine[3]), Convert.ToInt32(splitLine[4]));
        //            quizzes.Add(newQuiz);
        //        }

        //        foreach (Quiz q in quizzes)
        //        {
        //            if (q._quizID == questions.ElementAt(0)._id)
        //            {
        //                int timeTaken = q._timeTaken + 1;
        //                int totalScore = q._totalScore + score;

        //                q._timeTaken = timeTaken;
        //                q._totalScore = totalScore;

        //                average = Convert.ToDouble(q._totalScore) / Convert.ToDouble(q._timeTaken);

        //                lblTotalPeople.Text = string.Format("Total people to take quiz: {0}", q._timeTaken);
        //                lblAverageScore.Text = string.Format("Average score is: {0:f2}", average);
        //            }
        //        }

        //        string[] writeToFile = new string[quizzes.Count];

        //        for (int i = 0; i < quizzes.Count; i++)
        //        {
        //            Quiz currentQuiz = quizzes.ElementAt(i);
        //            writeToFile[i] = currentQuiz.WriteScoreTotal();
        //        }

        //        File.WriteAllLines((Server.MapPath("Quizzes.txt")), writeToFile);

        //        lblScore.Text = string.Format("Your score: {0}/6", score);

        //        DateTime timeStart = (DateTime)Session["timeStart"];
        //        TimeSpan timeTakenTime = DateTime.Now.Subtract(timeStart);
        //        lblTimeTaken.Text = string.Format("Time taken: {0:hh\\:mm\\:ss}", timeTakenTime);

        //    }
        //    else
        //        Response.Redirect("quizSelection.aspx");
            
        //}


        ////Display questions and answers

        //protected void DisplayAnswers(int index, Label lblID, RadioButtonList lstID)
        //{
        //    lblID.Text = questions.ElementAt(quesAnswered.ElementAt(index))._question;

        //    lstID.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(index))._option1, questions.ElementAt(quesAnswered.ElementAt(index))._option1));
        //    lstID.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(index))._option2, questions.ElementAt(quesAnswered.ElementAt(index))._option2));
        //    lstID.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(index))._option3, questions.ElementAt(quesAnswered.ElementAt(index))._option3));
        //    lstID.Items.Add(new ListItem(questions.ElementAt(quesAnswered.ElementAt(index))._option4, questions.ElementAt(quesAnswered.ElementAt(index))._option4));

        //    //If answer correct change tect colour to green
        //    //If answer wrong change text to red
        //    //Else set colour to black

        //    foreach (ListItem ans in lstID.Items)
        //    {
        //        if (ans.Value == answers[index])
        //            ans.Selected = true;

        //        if (ans.Selected == true && ans.Value == questions.ElementAt(quesAnswered.ElementAt(index))._answer)
        //        {
        //            ans.Attributes["style"] = "color:green";
        //            score += 1;
        //        }
        //        else if (ans.Selected == true && ans.Value != questions.ElementAt(quesAnswered.ElementAt(index))._answer)
        //            ans.Attributes["style"] = "color:red";
        //        else
        //            ans.Attributes["style"] = "color:black";
        //    }
        //}

        ////Restarts Quiz
        ////On click remove answers from session and redirect to question1.aspx

        //protected void btnRestartQuiz_Click(object sender, EventArgs e)
        //{
        //    Session.Remove("answers");
        //    Response.Redirect("question1.aspx");
        //}

        ////On click clear the session and redirect to quiz selection

        //protected void btnNewQuiz_Click(object sender, EventArgs e)
        //{
        //    Session.Clear();
        //    Session.Abandon();
        //    Response.Redirect("quizSelection.aspx");
        //}
    }
}