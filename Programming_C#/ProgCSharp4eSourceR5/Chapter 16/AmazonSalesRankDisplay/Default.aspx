<%@ Page Language="C#" CompileWith="Default.aspx.cs" ClassName="Default_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Sales Ranks</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        The data found here is from the Amazon Web Service and is stored in a local database.
        The data is updated every 15
        <br />
        minutes. This is a work in progress.<br />
        &nbsp;<br />
        <b>ASP Titles</b>
        <asp:GridView ID="gvASP" Runat="server" 
        OnRowDataBound="RowDataBound"
        AutoGenerateColumns="false"
        HeaderStyle-BackColor="PapayaWhip"
        BorderColor="#000099"
        AlternatingRowStyle-BackColor="LightGrey"
        HeaderStyle-Font-Bold=true
        Width="900">
            <Columns>
                <asp:TemplateField HeaderStyle-Width ="10">
                    <HeaderTemplate>
                        Position
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label Runat="server" ID="Label1"><%# rowNumber %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Title
                    </HeaderTemplate>
                    <ItemTemplate>
                        <a href="http://www.amazon.com/exec/obidos/ASIN/<%# Eval("isbn")%>/" target="_blank"><%# Eval("title") %></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Author" ReadOnly="true" DataField="Author" />
                <asp:BoundField HeaderText="Publisher" ReadOnly="true" DataField="Publisher" />
                <asp:BoundField HeaderText="Publish Date" ReadOnly="true" DataField="pubDate" />
                <asp:BoundField HeaderText="Rank" ReadOnly="true" DataField="Rank" DataFormatString="{0:N0}" ItemStyle-HorizontalAlign="right" />
            </Columns>
        </asp:GridView>

        <br />        
        <b>ASP Titles</b>
        <asp:GridView ID="gvCSharp" Runat="server"
        OnRowDataBound="RowDataBound"
        AutoGenerateColumns="false"
        HeaderStyle-BackColor="PapayaWhip"
        BorderColor="#000099"
        AlternatingRowStyle-BackColor="LightGrey"
        HeaderStyle-Font-Bold=true
        Width="900">
            <Columns>
                <asp:TemplateField HeaderStyle-Width ="10">
                    <HeaderTemplate>
                        Position
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label Runat="server" ID="Label2"><%# rowNumber %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Title
                    </HeaderTemplate>
                    <ItemTemplate>
                        <a href="http://www.amazon.com/exec/obidos/ASIN/<%# Eval("isbn")%>/" target="_blank"><%# Eval("title") %></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Author" ReadOnly="true" DataField="Author" />
                <asp:BoundField HeaderText="Publisher" ReadOnly="true" DataField="Publisher" />
                <asp:BoundField HeaderText="Publish Date" ReadOnly="true" DataField="pubDate" />
                <asp:BoundField HeaderText="Rank" ReadOnly="true" DataField="Rank" DataFormatString="{0:N0}" ItemStyle-HorizontalAlign="right" />
            </Columns>
        </asp:GridView>
        <br />
        <b>VB Titles</b>
        <asp:GridView ID="gvVBNet" Runat="server"
        OnRowDataBound="RowDataBound"
        AutoGenerateColumns="false"
        HeaderStyle-BackColor="PapayaWhip"
        BorderColor="#000099"
        AlternatingRowStyle-BackColor="LightGrey"
        HeaderStyle-Font-Bold=true
        Width="900">
            <Columns>
                <asp:TemplateField HeaderStyle-Width ="10">
                    <HeaderTemplate>
                        Position
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label Runat="server" ID="Label3"><%# rowNumber %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Title
                    </HeaderTemplate>
                    <ItemTemplate>
                        <a href="http://www.amazon.com/exec/obidos/ASIN/<%# Eval("isbn")%>/" target="_blank"><%# Eval("title") %></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Author" ReadOnly="true" DataField="Author" />
                <asp:BoundField HeaderText="Publisher" ReadOnly="true" DataField="Publisher" />
                <asp:BoundField HeaderText="Publish Date" ReadOnly="true" DataField="pubDate" />
                <asp:BoundField HeaderText="Rank" ReadOnly="true" DataField="Rank" DataFormatString="{0:N0}" ItemStyle-HorizontalAlign="right" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblLastUpdate" Runat="server" Text="Last Update"></asp:Label>
        <br />
        Number to show in grid:
        <asp:TextBox ID="txtShowRecords" Runat="server" Width="48px" Height="22px" AutoPostBack="True"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
