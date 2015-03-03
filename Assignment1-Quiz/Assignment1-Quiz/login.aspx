<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Assignment1_Quiz.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <!--Write your HTML here-->
    <label>First Name</label>
    <asp:TextBox ID="tbxFName" runat="server" />
    <asp:RequiredFieldValidator ID="rfvFName" ControlToValidate="tbxFName" ErrorMessage="*Please enter first name." runat="server" />

    <label>Last Name</label>
    <asp:TextBox ID="tbxLName" runat="server" />
    <asp:RequiredFieldValidator ID="rfvLName" ControlToValidate="tbxLName" ErrorMessage="*Please enter last name." runat="server" />

    <label>Email</label>
    <asp:TextBox ID="tbxEmail" runat="server" />
    <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="tbxEmail" ErrorMessage="*Please enter email." runat="server" />
    <asp:RegularExpressionValidator ID="revEmail" ControlToValidate="tbxEmail" ErrorMessage="*Invalid email." ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$" runat="server" />

    <label>Nationality</label>
    <asp:DropDownList ID="lstNationalities" runat="server" />
    <asp:RequiredFieldValidator ID="rfvNationality" ControlToValidate="lstNationalities" ErrorMessage="*Please select nationality." InitialValue="-- Select Nationality --" runat="server" />

    <label>Remember Me</label>
    <asp:CheckBox ID="chkRemember" runat="server" />

    <asp:Button ID="btnChoose" Text="Choose Quiz" OnClick="btnChoose_Click" runat="server" />
</asp:Content>
