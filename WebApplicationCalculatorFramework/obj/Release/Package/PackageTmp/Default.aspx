<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationCalculatorFramework._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2 class="text-center">Calculator</h2>

        <div class="text-center">
            <asp:Label Ib="Label1" runat="server" Text="Label">First value:</asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label Ib="Label1" runat="server" Text="Label">Second value:</asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label Ib="Label1" runat="server" Text="Label">Result:</asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        </div>
        <div class="text-center">
            <br />
            <br />


            <asp:Button ID="Button1" runat="server" OnClick="Add" Text="ADDITION" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Substract" Text="SUBSTRACTION" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Multiply" Text="MULTIPLY" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Divide" Text="DIVISION" />
        </div>

    </div>



</asp:Content>
