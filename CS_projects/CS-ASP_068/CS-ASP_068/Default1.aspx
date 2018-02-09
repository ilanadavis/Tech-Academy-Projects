<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="CS_ASP_068.Default1" %>

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
            <h1>Page Header</h1>
            <p class="lead">By line (lead)</p>
        </div>

        <div class="row">
            <div class="col-md-8 col-sm-6">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
            </div>
            <div class="col-md-4 col-sm-6">
                Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur? 
            </div>
        </div>

    <div class="form-group">
        <label>TextBox: </label>
        <asp:TextBox ID="testTextBox" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>DropdownList: </label>
        <asp:DropDownList ID="testDropDownList" runat="server" CssClass="form-control">
            <asp:ListItem Text="Option 1" Value="Small" />
            <asp:ListItem Text="Option 2" Value="Medium" />
            <asp:ListItem Text="Option 3" Value="Large" />
        </asp:DropDownList>
    </div>

    <div class="checkbox"><label><asp:CheckBox ID="testCheckBox" runat="server"></asp:CheckBox> CheckBox</label></div>
    
    <div class="radio"><label><asp:RadioButton ID="testRadioButton1" runat="server" GroupName="TestGroup"></asp:RadioButton> RadioButton 1</label></div>
    <div class="radio"><label><asp:RadioButton ID="testRadioButton2" runat="server" GroupName="TestGroup"></asp:RadioButton> RadioButton 1</label></div>

        <asp:Button ID="testButton" runat="server" Text="Test" CssClass="btn btn-lg btn-primary" />
    </div>
    </form>

    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
