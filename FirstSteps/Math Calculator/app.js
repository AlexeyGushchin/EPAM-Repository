"use strict";

function calculate(expression) {

    let numbersPattern = /\d*\.?\d+/gm;
    let operatorsPattern = /[\*\/+-]/gm;

    let numbers = str.match(numbersPattern);
    let operators = str.match(operatorsPattern);

    let sum = parseFloat(numbers[0]);

    for (let i = 1, j = 0; i < numbers.length; i++, j++) {

        sum = mathOperation(sum, numbers[i], operators[j]);
    }

    return sum.toFixed(2);
}


function mathOperation(firstOperand, secondOperand, operator) {

    firstOperand = parseFloat(firstOperand);
    secondOperand = parseFloat(secondOperand);

    switch (operator) {
        case "+":
            return firstOperand + secondOperand;
        case "-":
            return firstOperand - secondOperand;
        case "*":
            return firstOperand * secondOperand;
        case "/":
            return firstOperand / secondOperand;
        default:
            return 0;

    }
}


let str = "3.5 +4*10-5.3 /5 =";


console.log(calculate(str));