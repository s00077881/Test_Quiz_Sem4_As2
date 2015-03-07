<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="quizSelection.aspx.cs" Inherits="Assignment1_Quiz.quizSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div id="content">
        <div class="col-xs-12"><h2><span class="label label-default">Select Category</span></h2></div>

        <div class="col-md-3 col-sm-6 col-xs-6 ">
            <h3><span class="label label-default">General Knowledge</span></h3>
            <asp:ImageButton CausesValidation="false" ID="btnGeneralCat" CssClass="img-responsive hvr-wobble-vertical" runat="server" AlternateText="General Knowledge" ImageUrl="~/images/general.png" OnClick="btnCat_Click" />
        </div>

        <div class="col-md-3 col-sm-6 col-xs-6">
            <h3><span class="label label-default">Movies</span></h3>
            <asp:ImageButton CausesValidation="false" ID="btnMovieCat" CssClass="img-responsive hvr-wobble-vertical" runat="server" AlternateText="Movies" ImageUrl="~/images/movie.png" OnClick="btnCat_Click" />
        </div>

        <div class="col-md-3  col-sm-6 col-xs-6">
            <h3><span class="label label-default">Music</span></h3>
            <asp:ImageButton CausesValidation="false" ID="btnMusicCat1" CssClass="img-responsive hvr-wobble-vertical" runat="server" AlternateText="Music" ImageUrl="~/images/music.png" OnClick="btnCat_Click" />
        </div>

        <div class="col-md-3 col-sm-6 col-xs-6">
            <h3><span class="label label-default">Sports</span></h3>
            <asp:ImageButton CausesValidation="false" ID="btnSportCat" CssClass="img-responsive hvr-wobble-vertical" runat="server" AlternateText="Sports" ImageUrl="~/images/sport.png" OnClick="btnCat_Click"/>
        </div>

        <div class="col-md-12 formHolder">
            <div id="selectQuiz" class="col-md-6 col-xs-12"><!--LeftColumn-->
                <h2><span class="label label-default">Select Quiz</span></h2>
                <asp:DropDownList ID="lstQuizSelect" CssClass="form-control" runat="server"></asp:DropDownList>
<<<<<<< HEAD
                <asp:Button ID="startQuiz" CssClass="btn spacer btn-default" Text="Start Quiz" runat="server" OnClick="startQuiz_Click" />
=======
                <asp:RequiredFieldValidator ID="rFVSelectQuiz" ControlToValidate="lstQuizSelect" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*You Must Select A Category!" runat="server" />
                <asp:Button ID="startQuiz" CssClass="btn spacer" Text="Start Quiz" runat="server" OnClick="startQuiz_Click" />
>>>>>>> 517af5b6e7affe7ae9f1dc718f70d4ba4f9fc45d
            </div><!--EndLeftColumn-->

            <div class="col-md-6 col-xs-12"><!--RightColumn-->
                <h2 id="dropButton"><span class="label label-default">Create Quiz</span></h2>

                <div id="rightColumnDrop">

                    <div class="spacer">
                        <h3><span class="label label-default">Quiz Name</span></h3>
                        <asp:TextBox ID="tbxCreateName" placeholder="Quiz Name" CssClass="form-control " runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rFVQuizName" ControlToValidate="tbxCreateName" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Quiz Name Is Required!" ValidationGroup="CreateQuiz" runat="server" />
                    </div>

                    <div class="spacer">
                        <h3><span class="label label-default">Quiz Category</span></h3>
                        <asp:DropDownList ID="lstCat" CssClass="form-control " runat="server">
                            <asp:ListItem>General Knowledge</asp:ListItem>
                            <asp:ListItem>Movies</asp:ListItem>
                            <asp:ListItem>Music</asp:ListItem>
                            <asp:ListItem>Sports</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="spacer">
                        <h3><span class="label label-default">Select Question</span></h3>
                        <asp:DropDownList ID="lstAddQuiz" CssClass="form-control " runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstAddQuiz_SelectedIndexChanged">
                            <asp:ListItem>Question 1</asp:ListItem>
                            <asp:ListItem>Question 2</asp:ListItem>
                            <asp:ListItem>Question 3</asp:ListItem>
                            <asp:ListItem>Question 4</asp:ListItem>
                            <asp:ListItem>Question 5</asp:ListItem>
                            <asp:ListItem>Question 6</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="spacer">
                        <h3><span class="label label-default">Enter Question</span></h3>
                        <asp:TextBox ID="tbxEnterQuestion" CssClass="form-control " runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rFVQuestion" ControlToValidate="tbxEnterQuestion" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Question Is Required!" ValidationGroup="CreateQuiz" runat="server" />
                    </div>

                    <div class="spacer">
                        <div class="col-md-6 ">
                            <h3><span class="label label-default">Option1</span></h3>
                            <asp:TextBox ID="tbxOption1" CssClass="form-control col-md-3 formHolder" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rFVOption1" ControlToValidate="tbxOption1" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Option 1 Is Required!" ValidationGroup="CreateQuiz" runat="server" />
                        </div>

                        <div class="col-md-6">
                            <h3><span class="label label-default">Option2</span></h3>
                            <asp:TextBox ID="tbxOption2" CssClass="form-control col-md-3 formHolder" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rFVOption2" ControlToValidate="tbxOption2" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Option 2 Is Required!" ValidationGroup="CreateQuiz" runat="server" />
                        </div>

                        <div class="col-md-6">
                            <h3><span class="label label-default">Option3</span></h3>
                            <asp:TextBox ID="tbxOption3" CssClass="form-control col-md-3 formHolder" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rFVOption3" ControlToValidate="tbxOption3" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Option 3 Is Required!" ValidationGroup="CreateQuiz" runat="server" />
                        </div>

                        <div class="col-md-6">
                            <h3><span class="label label-default">Option4</span></h3>
                            <asp:TextBox ID="tbxOption4" CssClass="form-control col-md-3 formHolder" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rFVOption4" ControlToValidate="tbxOption4" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Option 4 Is Required!" ValidationGroup="CreateQuiz" runat="server" />
                        </div>
                    </div>

                    <div class="col-md-6 spacer">
                        <h3><span class="label label-default">Select Answer</span></h3>

                        <asp:DropDownList ID="lstSelectAns" CssClass="form-control " runat="server">
                            <asp:ListItem>Option 1</asp:ListItem>
                            <asp:ListItem>Option 2</asp:ListItem>
                            <asp:ListItem>Option 3</asp:ListItem>
                            <asp:ListItem>Option 4</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="spacer col-md-12">
<<<<<<< HEAD
                        <asp:Button ID="btnAdQuiz" CssClass="btn btn-default" Text="Add Quiz" runat="server" OnClick="btnAdQuiz_Click" />
=======
                        <asp:Button ID="btnAdQuiz" CssClass="btn" Text="Add Quiz" runat="server" ValidationGroup="CreateQuiz" OnClick="btnAdQuiz_Click" />
>>>>>>> 517af5b6e7affe7ae9f1dc718f70d4ba4f9fc45d
                    </div>
                </div><!--Right column Drop-->
            </div><!--EndRightColumn-->
        </div>
    </div><!--End content-->
</asp:Content>
