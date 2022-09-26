<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectItems.aspx.cs" Inherits="InvoiceMainDemo.SelectItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body 
        {
             background-image: url("backimg.jpg");
             font-family: 'Rubik', sans-serif;
        }
        .auto-style1 {
            margin-left: 0px;
        }
        .auto-style2 {
            width: 240px;
        }
        .auto-style3 {
            width: 72px;
        }
        .auto-style4 {
            width: 121px;
        }
        .auto-style5 {
            margin-left: 40px;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="0">
           <tr>
            <th colspan="3">
        <div class="auto-style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="General Store"></asp:Label>
        </div>
        <br />
            </th>
           </tr>
            <tr>
                <td class="auto-style4" >
       <strong><asp:Label ID="breadlb" runat="server" Text="Bread"></asp:Label></strong>
                    </td>
                <td class="auto-style2">
<asp:DropDownList ID="ddlBread" runat="server" OnSelectedIndexChanged="ddlBread_SelectedIndexChanged" style="margin-left: 0px" Width="106px">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
                     </td>
                    
                <td colspan="2">
        <asp:Label ID="lbBreadAmount" runat="server" Text="0"></asp:Label>
        <br />
        <br />
                    </td>
                </tr>
            <tr>
                <td >
        <strong><asp:Label ID="Ricelb" runat="server" Text="Rice"></asp:Label></strong>
                    </td>
                <td class="auto-style2">
        <asp:DropDownList ID="ddlRice" runat="server" OnSelectedIndexChanged="ddlRice_SelectedIndexChanged" Width="110px">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
                </td>
                <td colspan="2">
        <asp:Label ID="lbRiceAmount" runat="server" Text="0"></asp:Label>
        <br />
        <br />
                </td>
                </tr>
            <tr>
                <td class="auto-style4">
        <strong><asp:Label ID="Beanslb" runat="server" Text="Beans"></asp:Label></strong>
                    </td>
                <td class="auto-style2">
        <asp:DropDownList ID="ddlbeans" runat="server" OnSelectedIndexChanged="ddlbeans_SelectedIndexChanged" Width="110px">
            
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
                    
                    </td>
                <td colspan="2">
               
        <asp:Label ID="lbBeansAmount" runat="server" Text="0"></asp:Label>
        <br />
        <br />
                    </td>
                 </tr>
            <tr>
                <td class="auto-style4">
       <strong> <asp:Label ID="sugerlb" runat="server" Text="Suger"></asp:Label></strong>
                    </td>
                <td class="auto-style2">
        <asp:DropDownList ID="ddlsuger" runat="server" OnSelectedIndexChanged="ddlRice1_SelectedIndexChanged" Width="107px">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
                    
                    </td>
                <td colspan="2">
        <asp:Label ID="lbSugerAmount" runat="server" Text="0"></asp:Label>
        <br />
        <br />
                    </td>
                </tr>
            <tr>
                <td class="auto-style4">
       <strong><asp:Label ID="Milklb" runat="server" Text="Milk"></asp:Label></strong>
                    </td>
                <td class="auto-style2">
        <asp:DropDownList ID="ddlmilk" runat="server" OnSelectedIndexChanged="ddlmilk_SelectedIndexChanged" Width="110px">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
                    
                    </td>
                <td colspan="2">
        <asp:Label ID="lbMilkAmount" runat="server" Text="0"></asp:Label>
        <br />
        <br />
                    </td>
                </tr>
            <tr>
                <td class="auto-style4">
        <strong><asp:Label ID="Totallb" runat="server" Text="Total"></asp:Label></strong>
                    </td>
                <td class="auto-style2">
        <asp:Label ID="lbTotatlQuantity" runat="server" Text="000000"></asp:Label>
                    
                        &nbsp;</td>
                <td class="auto-style3" colspan="2">
        <asp:Label ID="lbTotalAmount" runat="server" Text="0"></asp:Label>
        <br />
        <br />
                    </td>
                </tr>
            </table>
        <br />
       <table>
           <tr>
           <th>
        <strong><asp:Button ID="BtnTotal" runat="server" OnClick="BtnTotal_Click" Text="Total" Width="130px" /></strong>
            </th>
               <th>
        <strong><asp:Button ID="BtnClear" runat="server" Text="Clear" Width="130px" OnClick="BtnClear_Click" /></strong>
                   </th>
               <th>
        <strong><asp:Button ID="BtnPaynow" runat="server" Text="Payment" Width="130px" OnClick="BtnPaynow_Click" /></strong>
               
                   </th>
               <th>
        <strong><asp:Button ID="BtnPayLater" runat="server" Text="Scearch Invoice" OnClick="BtnPayLater_Click" Width="144px" /></strong>
               </th>
               </tr>
           <tr>
               <th colspan="4" class="auto-style5">
        <strong><asp:Button ID="Btnlogout" runat="server" OnClick="Btnlogout_Click" Text="LogOut" Width="112px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                   <asp:Button ID="BtmHome" runat="server" OnClick="BtmHome_Click" Text="Home" Visible="False" Width="104px" />
                   </th>
                   </tr>
           <tr>
               <th colspan="4" class="auto-style5">
                   &nbsp;</th>
                   </tr>
           </table>
    </form>
</body>
</html>
