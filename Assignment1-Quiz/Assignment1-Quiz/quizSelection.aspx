<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="quizSelection.aspx.cs" Inherits="Assignment1_Quiz.quizSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div id="content">
        <div class="col-xs-12"><h2><span class="label label-default">Select Category</span></h2></div>
        <div class="col-md-3 col-sm-6 col-xs-6 ">
            <h3><span class="label label-default">General Knowledge</span></h3>
            <asp:ImageButton ID="btnGeneralCat" CssClass="img-responsive" runat="server" AlternateText="General Knowledge" ImageUrl="~/images/general.png" OnClick="btnCat_Click" />
        </div>
        <div class="col-md-3 col-sm-6 col-xs-6">
            <h3><span class="label label-default">Movies</span></h3>
            <asp:ImageButton ID="btnMovieCat" CssClass="img-responsive" runat="server" AlternateText="Movies" ImageUrl="~/images/movie.png" OnClick="btnCat_Click" />
        </div>
        <div class="col-md-3  col-sm-6 col-xs-6">
            <h3><span class="label label-default">Music</span></h3>
            <asp:ImageButton ID="btnMusicCat1" CssClass="img-responsive" runat="server" AlternateText="Music" ImageUrl="~/images/music.png" OnClick="btnCat_Click" />
        </div>
        <div class="col-md-3 col-sm-6 col-xs-6">
            <h3><span class="label label-default">Sports</span></h3>
            <asp:ImageButton ID="btnSportCat" CssClass="img-responsive" runat="server" AlternateText="Sports" ImageUrl="~/images/sport.png" OnClick="btnCat_Click"/>
        </div>
        <div class="col-md-12 formHolder">
            <div id="selectQuiz" class="col-md-6 col-xs-12"><!--LeftColumn-->
                <h2><span class="label label-default">Select Quiz</span></h2>
                <asp:DropDownList ID="lstQuizSelect" CssClass="form-control" runat="server"></asp:DropDownList>
                <asp:Button ID="startQuiz" CssClass="btn" Text="Start Quiz" runat="server" OnClick="startQuiz_Click" />
            </div><!--EndLeftColumn-->
            <div class="col-md-6 col-xs-12"><!--RightColumn-->
                <h2 id="dropButton"><span class="label label-default">Create Quiz</span></h2>
                <div id="rightColumnDrop">
                    <div class="spacer">
                        <h3><span class="label label-default">Quiz Name</span></h3>
                        <asp:TextBox ID="tbxCreateName" CssClass="form-control " runat="server"></asp:TextBox>
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
                        <asp:DropDownList ID="lstAddQuiz" CssClass="form-control " runat="server">
                            <asp:ListItem>Question 1</asp:ListItem>
                            <asp:ListItem>Question 2</asp:ListItem>
                            <asp:ListItem>Question 3</asp:ListItem>
                            <asp:ListItem>Question 4</asp:ListItem>
                            <asp:ListItem>Question 5</asp:ListItem>
                            <asp:ListItem>Question 6</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-12 spacer formHolder">
                        <div class="col-md-3 ">
                            <h3><span class="label label-default">Option1</span></h3>
                            <asp:TextBox ID="option1" CssClass="form-control col-md-3 formHolder" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-3">
                            <h3><span class="label label-default">Option2</span></h3>
                            <asp:TextBox ID="option2" CssClass="form-control col-md-3 formHolder" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-3">
                            <h3><span class="label label-default">Option3</span></h3>
                            <asp:TextBox ID="option3" CssClass="form-control col-md-3 formHolder" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-3">
                            <h3><span class="label label-default">Option4</span></h3>
                            <asp:TextBox ID="option4" CssClass="form-control col-md-3 formHolder" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div><!--EndRightColumn-->
        </div>
    </div><!--End content-->
</asp:Content>
