<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobsMegaChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="page-header">
            <h1>Papa Bob's Pizza</h1>
            <p class="lead">Pizza to Code By</p>
        </div>
        <div class="row">
            <div class="col-md-12 col-sm-6">

            </div>
        </div>
        <div class="form-group">
            <label>Size:</label>
            <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control">
                <asp:ListItem Text="Small (12 inch - $12)" Value="Small" />
                <asp:ListItem Text="Medium (14 inch - $14)" Value="Medium" />
                <asp:ListItem Text="Large (16 inch - $16)" Value="Large" />
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label>Crust:</label>
            <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control">
                <asp:ListItem Text="Regular" Value="Regular" />
                <asp:ListItem Text="Thin" Value="Thin" />
                <asp:ListItem Text="Thick (+ $2)" Value="Thick" />
            </asp:DropDownList>

        </div>
        <div class="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server"></asp:CheckBox> Sausage (+ $2)</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server"></asp:CheckBox> Pepperoni (+ $1.50)</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server"></asp:CheckBox> Onions (+ $1)</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="greenpeppersCheckBox" runat="server"></asp:CheckBox> Green Peppers (+ $1)</label></div>

        <h3>Deliver To:</h3>
        <div class="form-group">
            <label>Name:</label>
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control" CausesValidation="True" ValidationGroup="textbox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Address:</label>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control" CausesValidation="True" ValidationGroup="textbox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Zip:</label>
            <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control" CausesValidation="True" ValidationGroup="textbox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Phone:</label>
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control" CausesValidation="True" ValidationGroup="textbox"></asp:TextBox>
        </div>

        <h3>Payment:</h3>
        <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" Checked="True" GroupName="payment"></asp:RadioButton> Cash</label></div>
        <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="payment"></asp:RadioButton> Credit</label></div>

        <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-primary" />

        <h3>Total Cost:<asp:Label ID="resultLabel" runat="server"></asp:Label></h3>

    
    </div>
    </form>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
