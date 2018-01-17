<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="CS_ASP_020.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div>
            Type a value to add it to the string:<br />
            <br />
            Server Control:<br />
            <asp:TextBox ID="valueTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Plain ol&#39; HTML Input Text Field:<br />
            <asp:TextBox ID="textBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    
    </div>
    </form>
</body>
</html>
