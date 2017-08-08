<%@ Page Language="C#" CompileWith="HelloWeb.aspx.cs" ClassName="HelloWeb_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hello world. It is now <% =DateTime.Now.ToString() %>
    </div>
    </form>
</body>
</html>
