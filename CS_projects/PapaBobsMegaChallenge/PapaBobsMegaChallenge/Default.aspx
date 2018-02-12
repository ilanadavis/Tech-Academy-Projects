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
    
    </div>
    </form>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
