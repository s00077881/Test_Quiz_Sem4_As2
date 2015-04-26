<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" CodeBehind="userHistory.aspx.cs" Inherits="Assignment1_Quiz.userHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div class="col-xs-12 formHolder spacer">
        <asp:DropDownList ID="lstQuizzes" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="lstQuizzes_SelectedIndexChanged" runat="server">
                <asp:ListItem>All Quizzes</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="col-xs-12 text-center form-control spacer">
        <div class="col-xs-3 formHolder"><label>Date</label></div>
        <div class="col-xs-3 formHolder"><label>Quiz</label></div>
        <div class="col-xs-3 formHolder"><label>Time Taken</label></div>
        <div class="col-xs-3 formHolder"><label>Score</label></div>
    </div>

    <asp:GridView ID="gvAttempts" AutoGenerateColumns="false" ShowHeader="false" CssClass="col-xs-12" Font-Size="14px" runat="server">
        <RowStyle HorizontalAlign="Center" />
        <Columns>
            <asp:BoundField HeaderText="Date" DataField="Date" HtmlEncode="False" DataFormatString = "{0:d}" >
                <ItemStyle Width="25%"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField HeaderText="Quiz" DataField="Quiz" HtmlEncode="False" >
                <ItemStyle Width="25%"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField HeaderText="Time Taken" DataField="TimeTaken" HtmlEncode="False">
                <ItemStyle Width="25%"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField HeaderText="Score" DataField="Score">
                <ItemStyle Width="25%"></ItemStyle>
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    <div class="col-xs-12 text-center formHolder">
        <asp:Label CssClass="alert alert-danger label col-xs-12 spacer" ID="lblDbErrorNotice" runat="server" ></asp:Label>
    </div>
</asp:Content>
