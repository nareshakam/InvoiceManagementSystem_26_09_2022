<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upiPaymentVerification.aspx.cs" Inherits="InvoiceMainDemo.upiPaymentVerification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 600px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="UPI Verification"></asp:Label>
        </div>
        <asp:Button ID="BtnPaymentRecived" runat="server" OnClick="BtnPaymentRecived_Click" Text="PaymentRecived" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnPaymentFaild" runat="server" OnClick="BtnPaymentFaild_Click" Text="Payment declined" />
    </form>
</body>
</html>
