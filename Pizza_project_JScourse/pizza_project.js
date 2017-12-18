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
    var proteinTotal = getProtein(runningTotal,text1);
    var veggiesTotal = getVeggies(runningTotal,text1);
    var cheeseTotal = getCheese(runningTotal,text1);
    var crustTotal = getCrust(runningTotal,text1);
    runningTotal = sizeTotal + proteinTotal + veggiesTotal + cheeseTotal + crustTotal;
    console.log("Purchase Total: "+"$"+runningTotal+".00");

	document.getElementById("showText").innerHTML=text1;
	document.getElementById("totalPrice").innerHTML = "</h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
}
	
function getProtein(runningTotal,text1) {
	var proteinTotal = 0;
	var selectedProtein = [];
	var proteinArray = document.getElementsByClassName("Protein");
	for (var j = 0; j < proteinArray.length; j++) {
		if (proteinArray[j].checked) {
			selectedProtein.push(proteinArray[j].value);
			console.log("selected protein item: ("+proteinArray[j].value+")");
			text1 = text1+proteinArray[j].value+"<br>";
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
	console.log("protein text1: "+text1);
	return proteinTotal;  // protein subtotal
}	

function getVeggies(runningTotal,text1) {
	var veggiesTotal = 0;
	var selectedVeggies = [];
	var veggiesArray = document.getElementsByClassName("Veggies");
	for (var k = 0; k < veggiesArray.length; k++) {
		if (veggiesArray[k].checked) {
			selectedVeggies.push(veggiesArray[k].value);
			console.log("selected veggies item: ("+veggiesArray[k].value+")");
			text1 = text1+veggiesArray[k].value+"<br>";
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
	console.log("veggie text1: "+text1);
	return veggiesTotal;  // veggies subtotal
}

function getCheese(runningTotal,text1) {
	var cheeseTotal = 0;
	var selectedCheese = document.querySelector('input[name = "Cheese"]:checked').value;
	if (selectedCheese == "Extra Cheese") {
		cheeseTotal = 3;
	} else {
		cheeseTotal = 0;
	}
	console.log("total selected cheese items: "+cheeseTotal);
	console.log("cheese text1: "+text1);
	return cheeseTotal;  // cheese subtotal
}	

function getCrust(runningTotal,text1) {
	var crustTotal = 0;
	var selectedCrust = document.querySelector('input[name = "Crust"]:checked').value;
	if (selectedCrust == "Cheese Stuffed Crust") {
		crustTotal = 3;
	} else {
	crustTotal = 0;
	}
	console.log("total selected crust items: "+crustTotal);
	console.log("crust text1: "+text1);
	return crustTotal;  // crust subtotal
}	