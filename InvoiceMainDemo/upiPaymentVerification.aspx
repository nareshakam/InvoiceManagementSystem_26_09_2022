<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upiPaymentVerification.aspx.cs" Inherits="InvoiceMainDemo.upiPaymentVerification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body 
        {
             background-image: url("backimg.jpg");
             background-repeat: no-repeat;
             background-size: auto;
             font-family: 'Rubik', sans-serif;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="UPI Verification"></asp:Label>
            <br />
            <br />
        <asp:Button ID="BtnPaymentFaild" runat="server" OnClick="BtnPaymentFaild_Click" Text="Payment declined" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnPaymentRecived" runat="server" OnClick="BtnPaymentRecived_Click" Text="PaymentRecived" />
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>
