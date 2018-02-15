<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagement.aspx.cs" Inherits="PapaBobsMegaChallenge.OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:GridView ID="ordersGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="Order ID" DataSourceID="SqlDataSource1" OnRowCommand="ordersGridView_RowCommand">
            <Columns>
                <asp:ButtonField Text="Complete" />
                <asp:BoundField DataField="Order ID" HeaderText="Order ID" ReadOnly="True" SortExpression="Order ID" />
                <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
                <asp:BoundField DataField="Crust" HeaderText="Crust" SortExpression="Crust" />
                <asp:CheckBoxField DataField="Sausage" HeaderText="Sausage" SortExpression="Sausage" />
                <asp:CheckBoxField DataField="Pepperoni" HeaderText="Pepperoni" SortExpression="Pepperoni" />
                <asp:CheckBoxField DataField="Onions" HeaderText="Onions" SortExpression="Onions" />
                <asp:CheckBoxField DataField="Green Peppers" HeaderText="Green Peppers" SortExpression="Green Peppers" />
                <asp:BoundField DataField="Total Cost" HeaderText="Total Cost" SortExpression="Total Cost" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="PaymentType" HeaderText="PaymentType" SortExpression="PaymentType" />
                <asp:CheckBoxField DataField="Completed" HeaderText="Completed" SortExpression="Completed" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString %>" SelectCommand="SELECT * FROM [Orders]"></asp:SqlDataSource>
        
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
