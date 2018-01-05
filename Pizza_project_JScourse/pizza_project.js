function getReceipt() {
	var runningTotal = 0;
	var sizeTotal = 0;
	var sizeArray = document.getElementsByClassName("size");

    for (var i = 0; i < sizeArray.length; i++) {
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value;
        }
    } 
    
    // Price of each pizza size
    if (selectedSize === "Personal Pizza") {
        sizeTotal = 6;
    } else if (selectedSize === "Medium Pizza") {
    	sizeTotal = 10;
    } else if (selectedSize === "Large Pizza") {
    	sizeTotal = 14;
    } else if (selectedSize === "Extra Large Pizza") {
    	sizeTotal = 16;
    } 
    
    runningTotal = sizeTotal; 
    console.log(selectedSize+" = $"+sizeTotal+".00");
    console.log("subtotal: $"+runningTotal+".00");
    
    var proteinChoice = getProtein(); //names of proteins selected and dollar amounts for proteins
	var proteinLineItem = proteinChoice[0]; //list of proteins selected
	var proteinTotal = proteinChoice[1]; //dollar amounts for proteins

    var veggiesChoice = getVeggies(); //names of veggies selected and dollar amounts for veggies
	var veggiesLineItem = veggiesChoice[0]; //list of veggies selected
	var veggiesTotal = veggiesChoice[1]; //dollar amounts for veggies

    var cheeseChoice = getCheese(); //cheese selected and dollar amounts for cheese
    var selectedCheese = cheeseChoice[0]; //selected cheese
    var cheeseTotal = cheeseChoice[1]; //dollar amount for cheese

    var crustChoice = getCrust(); //crust selected and dollar amounts for crust
    var selectedCrust = crustChoice[0]; //selected crust
    var crustTotal = crustChoice[1]; //dollar amount for crust

    var sauceChoice = getSauce(); //sauce selected and dollar amounts for sauce
    var selectedSauce = sauceChoice[0]; //selected sauce
    var sauceTotal = sauceChoice[1]; //dollar amount for sauce

    runningTotal = sizeTotal + proteinTotal + veggiesTotal + cheeseTotal + crustTotal + sauceTotal;
    console.log("Purchase Total: "+"$"+runningTotal+".00");

	var receiptTable = "<table>";
	receiptTable+= writeReceipt(selectedSize, "$"+sizeTotal+".00");
	receiptTable+= writeReceipt(proteinLineItem || "No Protein", "+$"+proteinTotal+".00");
	receiptTable+= writeReceipt(veggiesLineItem || "No Veggies", "+$"+veggiesTotal+".00");
	receiptTable+= writeReceipt(selectedCheese, "+$"+cheeseTotal+".00");
	receiptTable+= writeReceipt(selectedCrust, "+$"+crustTotal+".00");
	receiptTable+= writeReceipt(selectedSauce, "+$"+sauceTotal+".00");	
	receiptTable+= "</table>";
	document.getElementById("showText").innerHTML="<h3>You Ordered:</h3>"+receiptTable;

	document.getElementById("totalPrice").innerHTML = "<h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
}
function writeReceipt(lineItem, linePrice) {
	return "<tr><td>"+lineItem+"</td><td>"+linePrice+"</td></tr>";
}
function getProtein() {
	var proteinTotal = 0;
	var selectedProtein = [];
	var proteinArray = document.getElementsByClassName("Protein");
	for (var j = 0; j < proteinArray.length; j++) {
		if (proteinArray[j].checked) {
			selectedProtein.push(proteinArray[j].value);
			console.log("selected protein item: ("+proteinArray[j].value+")");
		}
	}
	var proteinCount = selectedProtein.length;
	if (proteinCount > 1) {
		proteinTotal = (proteinCount - 1);
	} else {
		proteinTotal = 0;
	}
	console.log("total selected protein items: "+proteinCount);
	console.log(proteinCount+" protein - 1 free protein = "+"$"+proteinTotal+".00");
	return [selectedProtein.join(', '), proteinTotal];  // protein subtotal
}	

function getVeggies() {
	var veggiesTotal = 0;
	var selectedVeggies = [];
	var veggiesArray = document.getElementsByClassName("Veggies");
	for (var k = 0; k < veggiesArray.length; k++) {
		if (veggiesArray[k].checked) {
			selectedVeggies.push(veggiesArray[k].value);
			console.log("selected veggies item: ("+veggiesArray[k].value+")");
		}
	}
	var veggiesCount = selectedVeggies.length;
	if (veggiesCount > 1) {
		veggiesTotal = (veggiesCount - 1);
	} else {
		veggiesTotal = 0;
	}
	console.log("total selected veggie items: "+veggiesCount);
	console.log(veggiesCount+" veggie - 1 free veggie = "+"$"+veggiesTotal+".00");
	return [selectedVeggies.join(', '), veggiesTotal];  // veggies subtotal
}

function getCheese() {
	var cheeseTotal = 0;
	var selectedCheese = document.querySelector('input[name = "Cheese"]:checked').value;
	if (selectedCheese == "Extra Cheese") {
		cheeseTotal = 3;
	} else {
		cheeseTotal = 0;
	}
	console.log("total selected cheese items: "+cheeseTotal);
	return [selectedCheese, cheeseTotal]; //cheese selection and cheese subtotal
}	

function getCrust() {
	var crustTotal = 0;
	var selectedCrust = document.querySelector('input[name = "Crust"]:checked').value;
	if (selectedCrust == "Cheese Stuffed Crust") {
		crustTotal = 3;
	} else {
		crustTotal = 0;
	}
	console.log("total selected crust items: "+crustTotal);
	return [selectedCrust, crustTotal];  // crust selection and crust subtotal
}	

function getSauce() {
	var sauceTotal = 0;
	var selectedSauce = document.querySelector('input[name = "Sauce"]:checked').value;
	if (selectedSauce == "") {
		sauceTotal = 0;
	} else {
		sauceTotal = 0;
	}
	console.log("total selected sauce items: "+sauceTotal);
	return [selectedSauce, sauceTotal];  // sauce selection and sauce subtotal
}	