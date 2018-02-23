<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ToDo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="header">
        <h1>ToDo List</h1>
        <p>What's on your todo list?</p>
    </div>

    <!--Form element is located in Site.Master -->
    New ToDo:
    <input data-bind='value: itemToAdd, valueUpdate: "afterkeydown"'/>
    <button type="submit" data-bind="enable: itemToAdd().length > 0" class="btn btn-success btn-med">Add</button>
    
    <p>Your ToDo's:</p>
    <select multiple="multiple" size="5" style="min-width: 200px" "background: blue" data-bind="options: allItems, selectedOptions:selectedItems"></select>

    <div>
    <button data-bind="click: removeSelected, enable: selectedItems().length > 0" class="btn btn-danger btn-med">Remove</button>
    <button data-bind="click: sortItems, enable: allItems().length > 1" class="btn btn-primary btn-med">Sort</button>
</div>

</asp:Content>
