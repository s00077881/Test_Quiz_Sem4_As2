<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Assignment1_Quiz.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">


<div class="col-xs-12 col-md-6"><!--Left Column-->
    <div class="form-group"><!--First Name Input Field-->
        <h3><span class="label label-default col-md-12 col-xs-12 ">First Name</span></h3>
        <asp:TextBox ID="tbxFName"  CssClass="form-control" type="text" runat="server" />
        <asp:RequiredFieldValidator ID="rfvFName" CssClass="alert alert-danger label col-xs-12" ControlToValidate="tbxFName" Display="Dynamic" ErrorMessage="*Please enter first name." runat="server" />
    </div>

    <div class="form-group"><!--Last Name Input Field-->
        <h3><span class="label label-default col-md-12 col-xs-12 ">Last Name</span></h3>
        <asp:TextBox ID="tbxLName" for="usr" type="text" CssClass="form-control" runat="server" />
        <asp:RequiredFieldValidator ID="rfvLName" CssClass="alert alert-danger label col-xs-12 " ControlToValidate="tbxLName" Display="Dynamic" ErrorMessage="*Please enter last name." runat="server" />
    </div>
</div><!--End Left Column-->

<div class="col-xs-12 col-md-6"><!--Right Column-->
    <div class="form-group"><!--Email Input Field-->
        <h3><span class="label label-default col-md-12 col-xs-12 ">Email</span></h3>
        <asp:TextBox ID="tbxEmail" CssClass="form-control" runat="server" />
        <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="tbxEmail" CssClass="alert alert-danger label col-xs-12 " Display="Dynamic" ErrorMessage="*Please enter email." runat="server" />
        <asp:RegularExpressionValidator ID="revEmail" ControlToValidate="tbxEmail" CssClass="alert alert-danger label col-xs-12 " Display="Dynamic" ErrorMessage="*Invalid email." ValidationExpression="^[_a-zA-Z0-9-]+(\.[_a-zA-Z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$" runat="server" />
    </div>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Nationalities]" />

    <div class="form-group"><!--Nationality Input Field-->
        <h3><span class="label label-default col-md-12 col-xs-12 ">Nationality</span></h3>
        <asp:DropDownList CssClass="form-control" ID="lstNationalities" DataSourceID="SqlDataSource1" DataTextField="Nationality" DataValueField="id" runat="server" />
        <asp:RequiredFieldValidator ID="rfvNationality" CssClass="alert alert-danger label col-xs-12 " Display="Dynamic" ControlToValidate="lstNationalities" ErrorMessage="*Please select nationality." InitialValue="0" runat="server" />
    </div>

    <div class="checkbox"><!--Remember Me Checkbox-->
        <label class="pull-right"><asp:CheckBox CssClass=" checkbox"  ID="chkRemember" runat="server" />Remember Me</label>
    </div>
</div><!--End Right Column-->

<div class="col-sx-12">
    <asp:Button ID="btnChoose" CssClass=" spacer btn btn-default col-xs-12 col-md-6 col-md-offset-3" Text="Log In" OnClick="btnChoose_Click" runat="server" />
</div>
    


</asp:Content>
