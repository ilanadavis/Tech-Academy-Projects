<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="Challenge_First_Papa_Bobs_Pizza.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            color: #FF0000;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/PapaBob.png" />
&nbsp; <span class="auto-style1"><strong>Papa Bob&#39;s Pizza and Software</strong></span><br />
        <br />
        <asp:RadioButton ID="babyRadioButton" runat="server" GroupName="Size" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="mamaRadioButton" runat="server" GroupName="Size" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="papaRadioButton" runat="server" GroupName="Size" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="thincrustRadioButton" runat="server" GroupName="Type" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepdishRadioButton" runat="server" GroupName="Type" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionCheckBox" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenpeppersCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redpeppersCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
        <br />
        <br />
        <strong><span class="auto-style2"><span class="auto-style4">Papa Bob&#39;s </span><span class="auto-style3">Special Deal</span></span></strong><br />
        Save $2.00 when you add Pepperoni, Green Pepper and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.<br />
        <br />
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        <br />
        <br />
        Total:&nbsp; $<asp:Label ID="resultLabel" runat="server" Text="0.00"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better websit!</div>
    </form>
</body>
</html>
