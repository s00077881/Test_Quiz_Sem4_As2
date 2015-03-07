<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" CodeBehind="quizFinish.aspx.cs" Inherits="Assignment1_Quiz.quizFinish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div class="progress">
        <div class="progress-bar progress-bar-info progress-bar-striped" style="width: 100%"></div>
    </div>

    <div class="col-xs-12 col-md-6">
        <div class="spacer">
            <asp:Label ID="lblQuestion1" runat="server" />
            <asp:RadioButtonList ID="lstAnswers1" Enabled="false" runat="server" />
        </div>
        <div class="spacer">
            <asp:Label ID="lblQuestion2" runat="server" />
            <asp:RadioButtonList ID="lstAnswers2" Enabled="false" runat="server" />
        </div>
        <div class="spacer">
            <asp:Label ID="lblQuestion3" runat="server" />
            <asp:RadioButtonList ID="lstAnswers3" Enabled="false" runat="server" />
        </div>
        <div class="spacer">
            <asp:Label ID="lblQuestion4" runat="server" />
            <asp:RadioButtonList ID="lstAnswers4" Enabled="false" runat="server" />
        </div>
        <div class="spacer">
            <asp:Label ID="lblQuestion5" runat="server" />
            <asp:RadioButtonList ID="lstAnswers5" Enabled="false" runat="server" />
        </div>
        <div class="spacer">
            <asp:Label ID="lblQuestion6" runat="server" />
            <asp:RadioButtonList ID="lstAnswers6" Enabled="false" runat="server" />
        </div>
    </div>

    <asp:Label ID="lblScore" runat="server" />
    <asp:Label ID="lblTimeTaken" runat="server" />

</asp:Content>
