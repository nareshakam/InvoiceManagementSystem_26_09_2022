<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="InvoiceMainDemo.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body 
        {
             background-repeat: no-repeat;
             background-size: auto;
             background-image: url("loginimg.jpg");
             font-family: 'Rubik', sans-serif;
        }
        .auto-style1 {
            width: 855px;
        }
    </style>
    <title>Login Page</title>
</head>
<body style="margin-left: 448px; margin-top: 222px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Text="Login Page"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="User Name :-" Font-Bold="True" Font-Italic="True"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUserName" runat="server" Width="190px"></asp:TextBox>
        &nbsp;<br />
            <br />
        <asp:Label ID="Label2" runat="server" Text="Password :-" Font-Bold="True" Font-Italic="True"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" style="margin-left: 0px" Width="190px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblerrormessage" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Red" Visible="False"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="White" OnClick="Button1_Click" Text="Login" Font-Bold="True" Font-Italic="True" />
        </div>
    </form>
</body>
</html>
