<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Invoice.aspx.cs" Inherits="InvoiceMainDemo.Invoice" %>

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
   
</head>
<body>
    <form id="form1" runat="server">
        
        <div id="print1">
            <asp:Panel ID="pnl1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Invoice Number"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblInvoiceNumberResult" runat="server" Width="180px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
            <asp:Label ID="Label2" runat="server" Text="Invoice Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox placeholder="yyyy-mm-dd" ID="TxtDateData" runat="server" OnTextChanged="TxtDateData_TextChanged" Width="180px" TextMode="Date"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:Label ID="Label3" runat="server" Text="Invoice Status"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlPaidStatus" runat="server" Width="184px" Enabled="False" OnSelectedIndexChanged="ddlPaidStatus_SelectedIndexChanged">
                <asp:ListItem>--select--</asp:ListItem>
                <asp:ListItem>Paid</asp:ListItem>
                <asp:ListItem>UnPaid</asp:ListItem>
            </asp:DropDownList>
&nbsp;<asp:Label ID="lbldateerror" runat="server" ForeColor="Yellow" Visible="False"></asp:Label>
            &nbsp;
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="CustmerName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNameData" runat="server" Width="180px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="CustmerAdress"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAdressData" runat="server" Width="180px"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" style="margin-left: 8px" Width="423px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <br />
            &nbsp;<asp:Label ID="Label6" runat="server" Text="Total Invoice :-"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblInvoiceAmountResult" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblmessage" runat="server" Visible="False" ForeColor="Blue"></asp:Label>
            &nbsp;&nbsp;<br />
                <br />
    </asp:Panel>
&nbsp;<asp:Button ID="BtnSaveInvoice" runat="server" OnClick="BtnEdit_Click" Text="Save Invoice" Width="123px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnHome" runat="server" OnClick="BtnHome_Click" Text="Home" Width="134px" />
        &nbsp;&nbsp;&nbsp;
            </div>
    </form>
</body>
</html>
