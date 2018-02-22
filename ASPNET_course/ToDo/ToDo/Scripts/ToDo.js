
var ToDoModel = function()
{
    this.itemToAdd = ko.observable("");
    this.allItems = ko.observableArray([]);
    this.selectedItems = ko.observableArray([]);

    this.addItem = function () {
        if ((this.itemToAdd() != "") && (this.allItems.indexOf(this.itemToAdd()) < 0)) 
            this.allItems.push(this.itemToAdd());
        this.itemToAdd(""); 
    };

    this.removeSelected = function() 
    {
        this.allItems.removeAll(this.selectedItems());
        this.selectedItems([]);
    };

    this.sortItems = function()
    {
        this.allItems.sort();
    };

};

ko.applyBindings(new ToDoModel([]));