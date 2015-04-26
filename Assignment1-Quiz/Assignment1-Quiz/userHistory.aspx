<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" CodeBehind="userHistory.aspx.cs" Inherits="Assignment1_Quiz.userHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div class="col-xs-12 formHolder spacer">
        <div class="col-md-8 col-xs-12 formHolder">
            <asp:Label ID="lblDisplayUser" runat="server"></asp:Label>
        </div>
        <div class="col-md-4 col-xs-12 formHolder">
            <asp:Button ID="btnQuizSelect" CssClass="btn btn-default col-xs-12 col-md-12" Text="Select New Quiz" OnClick="btnQuizSelect_Click" runat="server" />
        </div>
    </div>

    <div class="col-xs-12 formHolder spacer">
        <asp:DropDownList ID="lstQuizzes" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="lstQuizzes_SelectedIndexChanged" runat="server">
                <asp:ListItem>All Quizzes</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="col-xs-12 text-center form-control spacer">
        <div class="col-xs-3 formHolder"><label>Quiz</label></div>
        <div class="col-xs-3 formHolder"><label>Date</label></div>
        <div class="col-xs-3 formHolder"><label>Time Taken</label></div>
        <div class="col-xs-3 formHolder"><label>Score</label></div>
    </div>

    <asp:GridView ID="gvAttempts" AutoGenerateColumns="false" ShowHeader="false" CssClass="col-xs-12" Font-Size="14px" runat="server">
        <RowStyle HorizontalAlign="Center" />
        <Columns>
            <asp:BoundField HeaderText="Quiz" DataField="Quiz" HtmlEncode="False" >
                <ItemStyle Width="25%"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField HeaderText="Date" DataField="Date" HtmlEncode="False" DataFormatString = "{0:d}" >
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

    <div class="col-xs-12 formHolder">
            <div id="chartContainer" class="ansSpacer" style="height: 300px; width: 100%;"></div>
    </div>

    <div class="col-xs-12 text-center formHolder">
        <asp:Label ID="lblDbErrorNotice" CssClass="alert alert-danger label col-xs-12 spacer" runat="server" ></asp:Label>
    </div>

    <script type="text/javascript">

        //Dispalys the the users score and average in a bar chart
        //http://canvasjs.com/editor/?id=http://canvasjs.com/example/gallery/column/oil_reserves/

        window.onload = function () {
            var chart = new CanvasJS.Chart("chartContainer",
            {
            title:{
                text: "Previous Scores"
            },
            animationEnabled: true,
            theme: "theme1",
            data: [
                {        
                    type: "spline",
                    dataPoints:[
                            <%=dataPoints%>
                    ]
                }   
            ]
            });

            chart.render();
        }
    </script>
    <script type="text/javascript" src="/js/canvasjs.min.js"></script>
</asp:Content>
