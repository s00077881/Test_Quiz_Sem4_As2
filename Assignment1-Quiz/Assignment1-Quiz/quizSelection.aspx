<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" CodeBehind="quizSelection.aspx.cs" Inherits="Assignment1_Quiz.quizSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div id="content">
        <div class="col-md-3 col-sm-6 col-xs-6 ">
            <label>General Knowledge</label>
            <asp:ImageButton ID="btnGeneralCat" CssClass="img-responsive" runat="server" AlternateText="General Knowledge" ImageUrl="~/images/general.png" OnClick="btnCat_Click" />
        </div>
        <div class="col-md-3 col-sm-6 col-xs-6">
            <label>Movies</label>
            <asp:ImageButton ID="btnMovieCat" CssClass="img-responsive" runat="server" AlternateText="Movies" ImageUrl="~/images/movie.png" OnClick="btnCat_Click" />
        </div>
        <div class="col-md-3  col-sm-6 col-xs-6">
            <label>Music</label>
            <asp:ImageButton ID="btnMusicCat1" CssClass="img-responsive" runat="server" AlternateText="Music" ImageUrl="~/images/music.png" OnClick="btnCat_Click" />
        </div>
        <div class="col-md-3 col-sm-6 col-xs-6">
            <label>Sports</label>
            <asp:ImageButton ID="btnSportCat" CssClass="img-responsive" runat="server" AlternateText="Sports" ImageUrl="~/images/sport.png" OnClick="btnCat_Click"/>
        </div>
        <div class="col-md-12">
            <div class="col-md-6 col-xs-12">
                <asp:DropDownList ID="lstQuizSelect" CssClass="form-control" runat="server"></asp:DropDownList>
                <asp:Button ID="startQuiz" Text="Start Quiz" runat="server" OnClick="startQuiz_Click" />
            </div>
        </div>
        
        
    </div><!--End content-->
</asp:Content>
