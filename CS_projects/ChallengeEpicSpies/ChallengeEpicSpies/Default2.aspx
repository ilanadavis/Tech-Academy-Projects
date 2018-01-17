<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="ChallengeEpicSpies.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            <br />
            <span class="auto-style1"><strong>Spy New Assignment Form</strong></span><br />
            <br />
            Spy Code Name:
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:
            <asp:Calendar ID="endOldAssignmentCalednar" runat="server" OnSelectionChanged="endOldAssignmentCalednar_SelectionChanged"></asp:Calendar>
            <br />
            Start Date of New Assignment:
            <asp:Calendar ID="startNewAssignmentCalednar" runat="server" OnSelectionChanged="startNewAssignmentCalednar_SelectionChanged"></asp:Calendar>
            <br />
            Projected End Date of New Assignment:
            <asp:Calendar ID="endNewAssignmentCalednar" runat="server" OnSelectionChanged="endNewAssignmentCalednar_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="assignSpyButton" runat="server" OnClick="assignSpyButton_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    
    </div>
    </form>
</body>
</html>
