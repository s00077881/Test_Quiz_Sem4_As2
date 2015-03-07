<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="quizSelection.aspx.cs" Inherits="Assignment1_Quiz.quizSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div id="content">
        <div class="col-xs-12"><h2><span class="label label-default">Select Category</span></h2></div>

        <div class="col-md-3 col-sm-6 col-xs-6 ">
            <h3><span class="label label-default labelSmall col-xs-12">General Knowledge</span></h3>
            <asp:ImageButton CausesValidation="false" ID="btnGeneralCat" CssClass="img-responsive hvr-wobble-vertical" runat="server" AlternateText="General Knowledge" ImageUrl="~/images/general.png" OnClick="btnCat_Click" />
        </div>

        <div class="col-md-3 col-sm-6 col-xs-6">
            <h3><span class="label label-default labelSmall col-xs-12">Movies</span></h3>
            <asp:ImageButton CausesValidation="false" ID="btnMovieCat" CssClass="img-responsive hvr-wobble-vertical" runat="server" AlternateText="Movies" ImageUrl="~/images/movie.png" OnClick="btnCat_Click" />
        </div>

        <div class="col-md-3  col-sm-6 col-xs-6">
            <h3><span class="label label-default labelSmall col-xs-12">Music</span></h3>
            <asp:ImageButton CausesValidation="false" ID="btnMusicCat1" CssClass="img-responsive hvr-wobble-vertical" runat="server" AlternateText="Music" ImageUrl="~/images/music.png" OnClick="btnCat_Click" />
        </div>

        <div class="col-md-3 col-sm-6 col-xs-6 ">
            <h3><span class="label label-default labelSmall col-xs-12">Sports</span></h3>
            <asp:ImageButton CausesValidation="false" ID="btnSportCat" CssClass="img-responsive hvr-wobble-vertical" runat="server" AlternateText="Sports" ImageUrl="~/images/sport.png" OnClick="btnCat_Click"/>
        </div>

        <div class="col-md-12 formHolder">
            <div id="selectQuiz" class="col-md-6 col-xs-12"><!--LeftColumn-->
                <h2><span class="label label-default">Select Quiz</span></h2>
                <asp:DropDownList ID="lstQuizSelect" CssClass="form-control" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rFVSelectQuiz" ControlToValidate="lstQuizSelect" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*You Must Select A Category!" runat="server" />
                <asp:Button ID="startQuiz" CssClass="btn btn-default spacer col-xs-12" Text="Start Quiz" runat="server" OnClick="startQuiz_Click" />
            </div><!--EndLeftColumn-->

            <div class="col-md-6 col-xs-12"><!--RightColumn-->
                <h2 id="dropButton"><span class="label label-default">Create Quiz</span></h2>

                <div id="rightColumnDrop">

                    <div class="spacer">
                        <h3><span class="label label-default labelSmall">Quiz Name</span></h3>
                        <asp:TextBox ID="tbxCreateName" placeholder="Quiz Name" CssClass="form-control " runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rFVQuizName" ControlToValidate="tbxCreateName" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Quiz Name Is Required!" ValidationGroup="CreateQuiz" runat="server" />
                    </div>

                    <div class="spacer">
                        <h3><span class="label label-default labelSmall">Quiz Category</span></h3>
                        <asp:DropDownList ID="lstCat" CssClass="form-control " runat="server">
                            <asp:ListItem>General Knowledge</asp:ListItem>
                            <asp:ListItem>Movies</asp:ListItem>
                            <asp:ListItem>Music</asp:ListItem>
                            <asp:ListItem>Sports</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="spacer">
                        <h3><span class="label label-default labelSmall">Select Question</span></h3>
                        <asp:DropDownList ID="lstSelectQuestion" CssClass="form-control " runat="server" AutoPostBack="true" CausesValidation="false" OnSelectedIndexChanged="lstSelectQuestion_SelectedIndexChanged">
                            <asp:ListItem>Question 1</asp:ListItem>
                            <asp:ListItem>Question 2</asp:ListItem>
                            <asp:ListItem>Question 3</asp:ListItem>
                            <asp:ListItem>Question 4</asp:ListItem>
                            <asp:ListItem>Question 5</asp:ListItem>
                            <asp:ListItem>Question 6</asp:ListItem>
                        </asp:DropDownList>
                        <asp:CustomValidator ID="cVlstSelectQuestion" Display="Dynamic" OnServerValidate="cVlstSelectQuestion_ServerValidate" CssClass="alert alert-danger col-xs-12 " runat="server" ErrorMessage="*All Questions/Answer Field Are Required!" ValidationGroup="CreateQuiz"></asp:CustomValidator>
                    </div>

                    <div class="spacer">
                        <h3><span class="label label-default labelSmall">Enter Question</span></h3>
                        <asp:TextBox ID="tbxEnterQuestion" CssClass="form-control " placeholder="Enter Question" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rFVQuestion" ControlToValidate="tbxEnterQuestion" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Question Is Required!" ValidationGroup="AddQues" runat="server" />
                    </div>

                    <div class="spacer">
                        <div class="col-md-6 ">
                            <h3><span class="label label-default labelSmall">Option1</span></h3>
                            <asp:TextBox ID="tbxOption1" CssClass="form-control col-md-3 formHolder" placeholder="Option 1" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rFVOption1" ControlToValidate="tbxOption1" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Option 1 Is Required!" ValidationGroup="AddQues" runat="server" />
                        </div>

                        <div class="col-md-6">
                            <h3><span class="label label-default labelSmall">Option2</span></h3>
                            <asp:TextBox ID="tbxOption2" CssClass="form-control col-md-3 formHolder" placeholder="Option 2" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rFVOption2" ControlToValidate="tbxOption2" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Option 2 Is Required!" ValidationGroup="AddQues" runat="server" />
                        </div>

                        <div class="col-md-6">
                            <h3><span class="label label-default labelSmall">Option3</span></h3>
                            <asp:TextBox ID="tbxOption3" CssClass="form-control col-md-3 formHolder" placeholder="Option 3" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rFVOption3" ControlToValidate="tbxOption3" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Option 3 Is Required!" ValidationGroup="AddQues" runat="server" />
                        </div>

                        <div class="col-md-6">
                            <h3><span class="label label-default labelSmall">Option4</span></h3>
                            <asp:TextBox ID="tbxOption4" CssClass="form-control col-md-3 formHolder" placeholder="Option 3" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rFVOption4" ControlToValidate="tbxOption4" CssClass="alert alert-danger col-xs-12 " Display="Dynamic" ErrorMessage="*Option 4 Is Required!" ValidationGroup="AddQues" runat="server" />
                        </div>

                        <div class="col-md-6 form-group">
                            <h3><span class="label label-default labelSmall">Select Answer</span></h3>
                            <asp:DropDownList ID="lstSelectAns" CssClass="form-control col-md-3 formHolder" runat="server">
                                <asp:ListItem>Option 1</asp:ListItem>
                                <asp:ListItem>Option 2</asp:ListItem>
                                <asp:ListItem>Option 3</asp:ListItem>
                                <asp:ListItem>Option 4</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="col-md-6">
                            <h3><span class="label label-default labelSmall">Add Question</span></h3>
                            <asp:Button ID="btnAddQuestion" Text="Add Question" CssClass=" form-control col-md-3 formHolder btn btn-default" OnClick="btnAddQuestion_Click" ValidationGroup="AddQues" runat="server" />
                        </div>

                    </div>
                    <div class="spacer col-md-12">
                        <asp:Button ID="btnAddQuiz" CssClass="btn btn-default col-xs-12" CausesValidation="true" Text="Add Quiz" runat="server" ValidationGroup="CreateQuiz" OnClick="btnAddQuiz_Click" />
                    </div>
                </div><!--Right column Drop-->
            </div><!--EndRightColumn-->
        </div>
    </div><!--End content-->
</asp:Content>
