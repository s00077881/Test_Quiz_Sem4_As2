<%@ Page Title="" Language="C#" MasterPageFile="~/quiz.Master" AutoEventWireup="true" CodeBehind="quizFinish.aspx.cs" Inherits="Assignment1_Quiz.quizFinish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentBlock" runat="server">

    <div class="progress">
        <div class="progress-bar progress-bar-success progress-bar-striped" style="width: 100%"></div>
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

    <div class="col-xs-12 col-md-6">
        <div class="col-xs-12">
            <asp:Label ID="lblTimeTaken" CssClass="" runat="server" />
        </div>

        <asp:Label ID="lblScore" runat="server" />
        <asp:Label ID="lblTotalPeople" runat="server" />
        <asp:Label ID="lblAverageScore" runat="server" />

        <div id="chartContainer" class="formHolder" style="height: 300px; width: 100%;"></div>

        <div class="col-md-12 spacer">
            <asp:Button ID="btnNewQuiz" Text="Select New Quiz" CssClass="btn btn-default col-xs-12 col-md-6" OnClick="btnNewQuiz_Click" runat="server" />
            <asp:Button ID="btnRestartQuiz" Text="Restart Quiz" CssClass="btn btn-default col-xs-12 col-md-6" OnClick="btnRestartQuiz_Click" runat="server" />
        </div>
    </div>


    <script type="text/javascript">

        //http://canvasjs.com/editor/?id=http://canvasjs.com/example/gallery/column/oil_reserves/

        window.onload = function () {
            var chart = new CanvasJS.Chart("chartContainer",
            {
            title:{
                text: "Score Comparison"
            },
            animationEnabled: true,
            axisY: {
                title: "Score",
                maximum: 6
            },
            theme: "theme1",
            data: [
                {        
                    type: "column",  
                    dataPoints: [      
                        {y: <%=score%>, label: "Your Score"},      
                        {y: Math.round(<%=average%> * 100) / 100, label: "Average Score" }
                    ]
                }   
            ]
            });

            chart.render();
        }
    </script>
    <script type="text/javascript" src="/js/canvasjs.min.js"></script>
</asp:Content>
