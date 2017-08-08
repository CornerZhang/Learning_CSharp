<%@ Page Language="C#" AutoEventWireup="true"  
CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Choose Shipper</title>
</head>
<body>
    <form id="form1" runat="server">
    <table >
        <tr>
            <td colspan="2" >Welcome to NorthWind</td>
        </tr>
        <tr>
            <td style="width: 78px">Your name:</td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 78px" >Shipper:</td>
            <td>
                <asp:RadioButtonList ID="rblShippers" Runat="server" DataSourceID="SqlDataSource1"
                    DataTextField="CompanyName" DataValueField="ShipperID">
                </asp:RadioButtonList>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 78px" ><asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" /></td>
            <td><asp:Button ID="btnCancel" runat="server" Text="Cancel" /></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Label id="lblMsg" runat="server"></asp:Label></td>
        </tr>
        
    
    </table>
                <asp:SqlDataSource ID="SqlDataSource1" Runat="server" SelectCommand="SELECT [ShipperID], [CompanyName] FROM [Shippers]"
                    ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>">
                </asp:SqlDataSource>
    
    
    </form>
</body>

</html>
