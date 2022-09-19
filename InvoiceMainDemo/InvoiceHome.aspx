<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvoiceHome.aspx.cs" Inherits="InvoiceMainDemo.InvoiceHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridViewMainInvoice" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewMainInvoice_SelectedIndexChanged">
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="InvoiceNumber :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtInviceNumberData" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="InvoiceDate :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDatedata" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Custmer Name :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnamedata" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="CustmerAdress :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAdressData" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="InvoiceStatus :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlStatus" runat="server">
            <asp:ListItem>--select--</asp:ListItem>
            <asp:ListItem>Paid</asp:ListItem>
            <asp:ListItem>UnPaid</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="BtnBuy" runat="server" OnClick="BtnBuy_Click" Text="Select to Buy" Width="211px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnScearch" runat="server" OnClick="Button2_Click" Text="Scearch Invoice" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnDelete" OnClientClick="return confirm('Are you Sure Want to Delete ?')" runat="server" OnClick="BtnDelete_Click" Text="Delete Invoice" Width="208px"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnUpdate" runat="server" Text="Update" Width="209px" OnClick="BtnUpdate_Click" />
    </form>
</body>
</html>
