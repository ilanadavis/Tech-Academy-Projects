function getReceipt() {
	var text1 = "<h3>You Ordered:</h3>";
	var runningTotal = 0;
	var sizeTotal = 0;
	var sizeArray = document.getElementsByClassName("size");

    for (var i = 0; i < sizeArray.length; i++) {
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value;
            text1 = text1+selectedSize+"<br>";
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
    console.log("size text1: "+text1);
    console.log("subtotal: $"+runningTotal+".00");
    
    // TODO Add additional charges of variables
    var proteinBox = getProtein(runningTotal); //names of proteins selected and dollar amounts for proteins
	var proteinLineItem = proteinBox[0]; //list of proteins selected
	var proteinTotal = proteinBox[1]; //dollar amounts for proteins

    var veggiesBox = getVeggies(runningTotal); //names of veggies selected and dollar amounts for veggies
	var veggiesLineItem = veggiesBox[0]; //list of veggies selected
	var veggiesTotal = veggiesBox[1]; //dollar amounts for veggies

    var cheeseBox = getCheese(runningTotal); //cheese selected and dollar amounts for cheese
    var selectedCheese = cheeseBox[0]; //selected cheese
    var cheeseTotal = cheeseBox[1]; //dollar amount for cheese

    var crustBox = getCrust(runningTotal); //crust selected and dollar amounts for crust
    var selectedCrust = crustBox[0]; //selected crust
    var crustTotal = crustBox[1]; //dollar amount for crust

    var sauceBox = getSauce(runningTotal); //sauce selected and dollar amounts for sauce
    var selectedSauce = sauceBox[0]; //selected sauce
    var sauceTotal = sauceBox[1]; //dollar amount for sauce

    runningTotal = sizeTotal + proteinTotal + veggiesTotal + cheeseTotal + crustTotal + sauceTotal;
    console.log("Purchase Total: "+"$"+runningTotal+".00");

	text1 = text1+proteinLineItem+"<br>"+veggiesLineItem+"<br>"+selectedCheese+"<br>"+selectedCrust+"<br>"+selectedSauce;
	
	document.getElementById("showText").innerHTML=text1;
	document.getElementById("totalPrice").innerHTML = "</h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
}
	
function getProtein(runningTotal) {
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

function getVeggies(runningTotal) {
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

function getCheese(runningTotal) {
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

function getCrust(runningTotal) {
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

function getSauce(runningTotal) {
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