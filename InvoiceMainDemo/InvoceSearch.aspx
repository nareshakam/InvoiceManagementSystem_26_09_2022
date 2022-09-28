<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvoceSearch.aspx.cs" Inherits="InvoiceMainDemo.InvoceSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body 
        {
             background-image: url("backimg.jpg");
             //background: #e35869;
             font-family: 'Rubik', sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInvoiceNumber" runat="server" Text="Invoice Number :"></asp:Label>
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtInvoiceNumberData" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnSearch" runat="server" OnClick="BtnSearch_Click" Text="Search" />
            <br />
            <asp:GridView ID="GridViewcardDetails" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="True">
            </asp:GridView>
            <br />
            <asp:Label ID="lbltotalAmount" runat="server" Text="Total Invoice Amount :" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblinvoiceresult" runat="server" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="ProductName :  "></asp:Label>
&nbsp;
            <asp:Label ID="lblNameData" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Product Quantity :  "></asp:Label>
&nbsp;
            <asp:DropDownList ID="ddlpquantity" runat="server" OnSelectedIndexChanged="ddlpquantity_SelectedIndexChanged">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Product Price :  "></asp:Label>
&nbsp;&nbsp;
            <asp:Label ID="lblPriceData" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnHome" runat="server" OnClick="Button1_Click" Text="Home" Width="95px" />
        </div>
    </form>
</body>
</html>
