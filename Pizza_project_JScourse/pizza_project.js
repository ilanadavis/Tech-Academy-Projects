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
    getProtein(runningTotal,text1);
    getVeggies(runningTotal,text1);// All three of these variables will be passed on to each function
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
	runningTotal += proteinTotal;
	console.log("total selected protein items: "+proteinCount);
	console.log(proteinCount+" protein - 1 free protein = "+"$"+proteinTotal+".00");
	console.log("protein text1: "+text1);
	console.log("Purchase Total: "+"$"+runningTotal+".00");
	document.getElementById("showText").innerHTML=text1;
	document.getElementById("totalPrice").innerHTML = "</h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
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
	runningTotal += veggiesTotal;
	console.log("total selected veggie items: "+veggiesCount);
	console.log(veggiesCount+" veggie - 1 free veggie = "+"$"+veggiesTotal+".00");
	console.log("veggie text1: "+text1);
	console.log("Purchase Total: "+"$"+runningTotal+".00");
	document.getElementById("showText").innerHTML=text1;
	document.getElementById("totalPrice").innerHTML = "</h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
}	