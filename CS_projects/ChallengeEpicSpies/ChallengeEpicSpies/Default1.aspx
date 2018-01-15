<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="ChallengeEpicSpies.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            <br />
            Spy New Assignment Form<br />
            <br />
            Spy Code Name:
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:<br />
            <asp:Calendar ID="endOldAssignmentCalendar" runat="server" OnSelectionChanged="endOldAssignmentCalendar_SelectionChanged"></asp:Calendar>
            <br />
            Start Date of New Assignment:<br />
            <asp:Calendar ID="startNewAssignmentCalendar" runat="server" OnSelectionChanged="startNewAssignmentCalendar_SelectionChanged"></asp:Calendar>
            <br />
            Projected End Date of New Assignment:<br />
            <asp:Calendar ID="endNewAssignmentCalendar" runat="server" OnSelectionChanged="endNewAssignmentCalendar_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
            <br />
            <asp:Label ID="resultsLabel" runat="server"></asp:Label>
        </div>
    
    </div>
    </form>
</body>
</html>
