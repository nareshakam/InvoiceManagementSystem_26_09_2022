<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvoiceHome.aspx.cs" Inherits="InvoiceMainDemo.InvoiceHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body 
        {
             background-image: url("backimg.jpg");
             font-family: 'Rubik', sans-serif;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridViewMainInvoice" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewMainInvoice_SelectedIndexChanged" BorderStyle="None">
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="InvoiceNumber :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtInviceNumberData" runat="server" OnTextChanged="txtInviceNumberData_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="InvoiceDate :-"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDatedata" runat="server" TextMode="DateTime" OnTextChanged="txtDatedata_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Custmer Name :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnamedata" runat="server" OnTextChanged="txtnamedata_TextChanged"></asp:TextBox>
        <asp:Label ID="lblnameerror" runat="server" Enabled="False" ForeColor="Yellow" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="CustmerAdress :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtAdressData" runat="server" OnTextChanged="txtAdressData_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="InvoiceStatus :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlStatus" runat="server" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
            <asp:ListItem>--select--</asp:ListItem>
            <asp:ListItem>Paid</asp:ListItem>
            <asp:ListItem>UnPaid</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblTotal" runat="server" Enabled="False" Text="Total amount :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbTotalResult" runat="server" Enabled="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblmessage" runat="server" Enabled="False" ForeColor="Green" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="BtnBuy" runat="server" OnClick="BtnBuy_Click" Text="Select to Buy" Width="140px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnScearch" runat="server" OnClick="Button2_Click" Text="Scearch Invoice" Width="152px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnScearchInvoiceNumber" runat="server" OnClick="Button1_Click" Text="Invoicenumberby Name" Width="213px" />
&nbsp;&nbsp;&nbsp;<br />
        <br />
&nbsp;<asp:Button ID="BtnDelete" OnClientClick="return confirm('Are you Sure Want to Delete ?')" runat="server" OnClick="BtnDelete_Click" Text="Delete Invoice" Width="165px"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnUpdate" runat="server" Text="Update" Width="159px" OnClick="BtnUpdate_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btnlogout" runat="server" OnClick="Btnlogout_Click" Text="LogOut" Width="149px" />
        <br />
        <asp:GridView ID="GridViewScearchInvoiceNumber" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewScearchInvoiceNumber_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
