<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" CodeBehind="quizSelection.aspx.cs" Inherits="Assignment1_Quiz.quizSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div id="content">

        <asp:Button ID="btnSportCat" Text="Sports" CssClass="test" runat="server" OnClick="btnCat_Click"/>
        <asp:Button ID="btnGeneralCat" Text="General Knowledge" runat="server" OnClick="btnCat_Click"/>
        <asp:Button ID="btnPopCat" Text="Pop Culture" runat="server" />
        <asp:Button ID="btnMovieCat" Text="Movies" runat="server" />
        <asp:DropDownList ID="lstQuizSelect" runat="server"></asp:DropDownList>
        <asp:Button ID="startQuiz" Text="Start Quiz" runat="server" OnClick="startQuiz_Click" />
    </div><!--End content-->
</asp:Content>
