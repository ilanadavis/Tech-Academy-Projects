
var txt1 = document.getElementById("txt1");
var txt2 = document.getElementById("txt2");
var total = document.getElementById("total");

function Calc() {
    var result = document.querySelector('input[name="calc"]:checked').value; //checked?
    var num1 = parseInt(txt1.value); console.log(typeof num1); console.log(isNaN(num1));
    var num2 = parseInt(txt2.value); console.log(typeof num2); console.log(isNaN(num2));
    if(result == "*") {
        total.innerHTML = (num1 * num2).toFixed(2);
    } else if(result == "/") {
        total.innerHTML = (num1 / num2).toFixed(2); //precise to the tenths place
    } else if(result == "+") {
        total.innerHTML = (num1 + num2).toFixed(2);
    } else if(result == "-") {
        total.innerHTML = (num1 - num2).toFixed(2);
    };
};
function Clear() {
    txt1.value=""; txt2.value=""; total.innerHTML="0.00"; //reset fields
};
