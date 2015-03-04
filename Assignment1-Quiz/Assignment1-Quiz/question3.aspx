<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" CodeBehind="question3.aspx.cs" Inherits="Assignment1_Quiz.question3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div class="progress">
        <div class="progress-bar progress-bar-info" style="width: 49.8%"></div>
    </div>

    <asp:Label ID="lblQuestion" runat="server" />
    <asp:RadioButtonList ID="lstAnswers" runat="server" />

    <asp:Button ID="btnPrevQuestion" Text="Previous Question" OnClick="btnPrevQuestion_Click" runat="server" />
    <asp:Button ID="btnNextQuestion" Text="Next Question" OnClick="btnNextQuestion_Click" runat="server" />
</asp:Content>
