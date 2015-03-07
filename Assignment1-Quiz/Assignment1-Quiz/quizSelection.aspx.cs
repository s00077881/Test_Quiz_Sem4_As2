using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Assignment1_Quiz
{
    /// <summary>
    /// Group:
    /// 
    /// Brian Geraghty
    /// s00077881
    /// -------------
    /// Fergal Gaffney
    /// s00147036
    /// -------------
    /// 
    /// Assignment 1 - Web Programming
    /// 
    /// Asp.net
    /// Bootstrap
    /// jQuery
    /// 
    /// GitHub : https://github.com/CollegeAssignments/Sem4_WebProg_Quiz
    /// </summary>


    public partial class quizSelection : System.Web.UI.Page
    {
        //List of currently loaded quizzes // Populate from text file "Quizzes.txt"
        public List<Quiz> quizCurrentList = new List<Quiz>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        /***************************************
         * Populate category dropdown on select 
         * quiz based on user selection
         * ************************************/

        protected void btnCat_Click(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            Quiz quiz;

            string[] readFile = File.ReadAllLines(Server.MapPath("Quizzes.txt"));
            string[] splitLine;

            for (int i = 0; i < readFile.Length; i++)
            {
                splitLine = readFile[i].Split(',');
                if (splitLine[2] == btn.AlternateText)
                {
                    quiz = new Quiz(splitLine[0], splitLine[1], splitLine[2]);
                    quizCurrentList.Add(quiz);
                }
            }

            lstQuizSelect.Items.Clear();

            //Add quiz dropdown list
            for (int i = 0; i < quizCurrentList.Count; i++)
            {
                lstQuizSelect.Items.Add(new ListItem(quizCurrentList.ElementAt(i)._quizName, quizCurrentList.ElementAt(i)._quizID));
            }
        }


        /*********************************
         * On click loads the questions for the
         * selected quiz and stores them in the
         * session. Redirects to question1.aspx
         *********************************/

        protected void startQuiz_Click(object sender, EventArgs e)
        {
            List<QuizQuestions> questions = new List<QuizQuestions>();

            QuizQuestions question;
            string[] readFile = File.ReadAllLines(Server.MapPath("QuizQuestions.txt"));
            string[] splitLine;


            for (int i = 0; i < readFile.Length; i++)
            {
                splitLine = readFile[i].Split(',');
                if (splitLine[0] == lstQuizSelect.SelectedValue)
                {
                    question = new QuizQuestions(splitLine[0],splitLine[1], splitLine[2], splitLine[3], splitLine[4], splitLine[5], splitLine[6]);
                    questions.Add(question);
                }
            }

            Session.Add("timeStart", DateTime.Now);
            Session.Add("questions", questions);
            Session.Add("quesAnswered", RandomArray());
            Response.Redirect("question1.aspx");
        }


        /******************************************
         * Creates an aray to display the questions
         * in a random order
         * ****************************************/

        protected List<int> RandomArray()
        {
            List<int> quesAnswered = new List<int>();
            Random rnd = new Random();
            int num;

            while (quesAnswered.Count < 6)
            {
                num = rnd.Next(0, 6);

                if (!quesAnswered.Contains(num))
                    quesAnswered.Add(num);

            }

            return quesAnswered;
        }


        /*****************************************************************
         * Adds new quiz and questions to quizzes.txt and quizQuestions.txt
         * ***************************************************************/

        protected void btnAddQuiz_Click(object sender, EventArgs e)
        {
            /************************************
             Add New Quiz To The Quizzes Text File
             ************************************/
            if (IsPostBack)
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "IsPostBack", "var isPostBack = true;", true);
            }

            if (IsValid)
            {
                List<Quiz> newQuiz = new List<Quiz>();

                Quiz readQuiz;

                //Get quiz information (name, category)
                string name = tbxCreateName.Text;
                string category = lstCat.SelectedValue;

                //Read in text file
                string[] readFile = File.ReadAllLines(Server.MapPath("Quizzes.txt"));
                string[] splitLine;

                for (int i = 0; i < readFile.Length; i++)
                {
                    splitLine = readFile[i].Split(',');
                    readQuiz = new Quiz(splitLine[0], splitLine[1], splitLine[2]);
                    newQuiz.Add(readQuiz);
                }

                string id = Convert.ToString(newQuiz.Count + 1);

                //Add new quiz to the newquiz list
                readQuiz = new Quiz(id, name, category);
                newQuiz.Add(readQuiz);

                //Write collection to "Quizzes.txt" file
                string[] writeToFile = new string[newQuiz.Count];

                for (int i = 0; i < newQuiz.Count; i++)
                {
                    Quiz currentQuiz = newQuiz.ElementAt(i);
                    writeToFile[i] = currentQuiz.WriteFormat();
                }
                File.WriteAllLines((Server.MapPath("Quizzes.txt")), writeToFile);


                /************************************************
                 Add New Question To The Quiz Question Text File
                 ************************************************/
                List<QuizQuestions> oldQuestions = new List<QuizQuestions>();
                List<QuizQuestions> newQuestions = (List<QuizQuestions>)ViewState["formQuestions"];


                //Read in text file
                readFile = File.ReadAllLines(Server.MapPath("QuizQuestions.txt"));
                QuizQuestions qq;


                //Read in quizQuestion text file
                for (int i = 0; i < readFile.Length; i++)
                {
                    splitLine = readFile[i].Split(',');
                    qq = new QuizQuestions(splitLine[0], splitLine[1], splitLine[2], splitLine[3], splitLine[4], splitLine[5], splitLine[6]);
                    oldQuestions.Add(qq);
                }

                for (int i = 0; i < newQuestions.Count; i++)
                {
                    qq = new QuizQuestions(
                        id,
                        newQuestions.ElementAt(i)._question,
                        newQuestions.ElementAt(i)._option1,
                        newQuestions.ElementAt(i)._option2,
                        newQuestions.ElementAt(i)._option3,
                        newQuestions.ElementAt(i)._option4,
                        newQuestions.ElementAt(i)._answer
                        );
                    oldQuestions.Add(qq);
                }

                //Write collection to "QuizQuestions.txt" file
                writeToFile = new string[oldQuestions.Count];


                for (int i = 0; i < oldQuestions.Count; i++)
                {
                    QuizQuestions curQuestion = oldQuestions.ElementAt(i);
                    writeToFile[i] = curQuestion.WriteQuestions();
                }

                File.WriteAllLines((Server.MapPath("QuizQuestions.txt")), writeToFile);
            }
        }


        /*******************************************************
         * on selected index changes (question dropdown) populate 
         * form fields with appropriate data
         * *****************************************************/


        protected void lstSelectQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check if postback to stop jQuery animation closing (create quiz dropdown)
            if (IsPostBack)
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "IsPostBack", "var isPostBack = true;", true);
            }

            List<QuizQuestions> quizQ = (List<QuizQuestions>)ViewState["formQuestions"];

            if (quizQ != null)
            {
                if (quizQ[lstSelectQuestion.SelectedIndex]._question == null)
                {
                    tbxEnterQuestion.Text = string.Empty;
                    tbxOption1.Text = string.Empty;
                    tbxOption2.Text = string.Empty;
                    tbxOption3.Text = string.Empty;
                    tbxOption4.Text = string.Empty;

                    lstSelectAns.SelectedIndex = 0;

                }
                else
                {
                    tbxEnterQuestion.Text = quizQ[lstSelectQuestion.SelectedIndex]._question;
                    tbxOption1.Text = quizQ[lstSelectQuestion.SelectedIndex]._option1;
                    tbxOption2.Text = quizQ[lstSelectQuestion.SelectedIndex]._option2;
                    tbxOption3.Text = quizQ[lstSelectQuestion.SelectedIndex]._option3;
                    tbxOption4.Text = quizQ[lstSelectQuestion.SelectedIndex]._option4;

                    if (quizQ[lstSelectQuestion.SelectedIndex]._answer == tbxOption1.Text)
                        lstSelectAns.SelectedIndex = 0;
                    else if (quizQ[lstSelectQuestion.SelectedIndex]._answer == tbxOption2.Text)
                        lstSelectAns.SelectedIndex = 1;
                    else if (quizQ[lstSelectQuestion.SelectedIndex]._answer == tbxOption3.Text)
                        lstSelectAns.SelectedIndex = 2;
                    else
                        lstSelectAns.SelectedIndex = 3;
                }
            }
            else
            {
                tbxEnterQuestion.Text = string.Empty;
                tbxOption1.Text = string.Empty;
                tbxOption2.Text = string.Empty;
                tbxOption3.Text = string.Empty;
                tbxOption4.Text = string.Empty;

                lstSelectAns.SelectedIndex = 0;
            }
        }

        /*********************************************************
         * Add question to list of stored questions 
         * Store list in viewstate
         * *******************************************************/

        protected void btnAddQuestion_Click(object sender, EventArgs e)
        {
            //Check if postback to stop jQuery animations breaking
            if (IsPostBack)
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "IsPostBack", "var isPostBack = true;", true);
            }

            if (IsValid)
            {
                //Store questions added to quiz form
                List<QuizQuestions> quizQ = new List<QuizQuestions>();
                QuizQuestions curQues = new QuizQuestions();

                string selectedAns = "";

                switch (lstSelectAns.SelectedIndex)
                {
                    case 0:
                        selectedAns = tbxOption1.Text;
                        break;
                    case 1:
                        selectedAns = tbxOption2.Text;
                        break;
                    case 2:
                        selectedAns = tbxOption3.Text;
                        break;
                    case 3:
                        selectedAns = tbxOption4.Text;
                        break;
                }

                if (ViewState["formQuestions"] != null)
                    quizQ = (List<QuizQuestions>)ViewState["formQuestions"];
                else
                {
                    for (int i = 0; i < 6; i++)
                    {
                        quizQ.Insert(i, curQues);
                    }
                }

                curQues = new QuizQuestions(tbxEnterQuestion.Text, tbxOption1.Text, tbxOption2.Text, tbxOption3.Text, tbxOption4.Text, selectedAns);
                quizQ[lstSelectQuestion.SelectedIndex] = curQues;
                ViewState.Add("formQuestions", quizQ);
            }
        }

        /********************************************************
         *Validate that all 6 questions and their sets of answers
         *have been populated
         ********************************************************/

        protected void cVlstSelectQuestion_ServerValidate(object source, ServerValidateEventArgs args)
        {
            List<QuizQuestions> quizQ = new List<QuizQuestions>();
            quizQ = (List<QuizQuestions>)ViewState["formQuestions"];

            if (quizQ == null)
            {
                args.IsValid = false;
            }
            else
            {
                foreach (QuizQuestions qq in quizQ)
                {
                    if (qq._question == null ||
                        qq._option1 == null ||
                        qq._option2 == null ||
                        qq._option3 == null ||
                        qq._option4 == null
                        )
                    {
                        args.IsValid = false;
                    }
                }
            }
        }
    }
}