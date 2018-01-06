<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-size: large;
            background-color: #3366FF;
        }
    </style>
</head>
<body>
    <h1>Simple Calculator</h1>
    <form id="form1" runat="server">
        <p>
            <span class="auto-style1">First Value:&nbsp; </span>
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
            <br />
            <span class="auto-style1">Second Value: </span>
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" Width="25px" />
&nbsp;
            <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" Width="25px" />
&nbsp;
            <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" Width="25px" />
&nbsp;
            <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" Width="25px" />
        </p>
    <div>
    
        <p>
            <strong>
            <asp:Label ID="resultsLabel" runat="server" CssClass="auto-style2"></asp:Label>
            </strong>
        </p>
    
    </div>
    </form>
</body>
</html>
