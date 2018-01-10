<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="CS_ASP_011.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div>
            Is
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
            <br />
            <br />
            <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
            <br />
            <br />
            If you could eat only one food for the rest of your life, what would you choose?<br />
            <asp:RadioButton ID="pizzaRadioButton" runat="server" Text="Pizza" GroupName="FoodGroup" />
            <br />
            <asp:RadioButton ID="saladRadioButton" runat="server" Text="Salad" GroupName="FoodGroup" />
            <br />
            <asp:RadioButton ID="pbjRadioButton" runat="server" Text="Peanut Butter and Jelly" GroupName="FoodGroup" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    
    </div>
    </form>
</body>
</html>
