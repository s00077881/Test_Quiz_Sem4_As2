<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="quizSelection.aspx.cs" Inherits="Assignment1_Quiz.quizSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div id="content">

        <div class="col-xs-12"><h2><span class="label label-default">Select Category</span></h2></div>
        <div class="col-xs-12"><p class="instructions"><span class="label label-black">To Start Select A Category From The Sections Below.</span></p></div>


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

                <div class="col-xs-12 formHolder"><h2><span class="label label-default">Select Quiz</span></h2></div>
                <div class="col-xs-12 formHolder"><p class="instructions"><span class="label label-black">Next Select A Quiz From The List.</span></p></div>
                <div class="col-xs-12 formHolder spacer"><asp:DropDownList ID="lstQuizSelect" CssClass="form-control" runat="server"></asp:DropDownList></div>
                <asp:RequiredFieldValidator ID="rFVSelectQuiz" ControlToValidate="lstQuizSelect" CssClass="alert alert-danger label col-xs-12 " Display="Dynamic" ErrorMessage="*You Must Select A Category!" runat="server" />
                <asp:Button ID="startQuiz" CssClass="btn btn-default spacer col-xs-12 " Text="Start Quiz" runat="server" OnClick="startQuiz_Click" />

            </div><!--EndLeftColumn-->

            <div class="col-md-6 col-xs-12"><!--RightColumn-->
                <asp:Button ID="prvResults" CssClass="btn btn-default col-xs-12 spacer" Text="Quiz History" runat="server" CausesValidation="false" OnClick="prvResults_Click"/>
            </div><!--EndRightColumn-->

            <div class="col-xs-12 text-center formHolder">
                <asp:Label CssClass="alert alert-danger label col-xs-12 spacer" ID="lblDbErrorNotice" runat="server" ></asp:Label>
            </div>
        </div>
    </div><!--End content-->
</asp:Content>
