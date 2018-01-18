<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="CS_ASP_022.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        From:<br />
        <br />
    
        <asp:RadioButton ID="fromChicagoRadioButton" runat="server" GroupName="from" Text="Chicago" />
        <br />
        <asp:RadioButton ID="fromNewYorkRadioButton" runat="server" GroupName="from" Text="New York" />
        <br />
        <asp:RadioButton ID="fromLondonRadioButton" runat="server" GroupName="from" Text="London" />
        <br />
        <br />
        To:<br />
        <br />
        <asp:RadioButton ID="toChicagoRadioButton" runat="server" GroupName="to" Text="Chicago" />
        <br />
        <asp:RadioButton ID="toNewYorkRadioButton" runat="server" GroupName="to" Text="New York" />
        <br />
        <asp:RadioButton ID="toLondonRadioButton" runat="server" GroupName="to" Text="London" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        Ticket Price: <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
