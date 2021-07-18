
/* https://replit.com/ */
/* Big O Complexity Chart: https://www.bigocheatsheet.com/ */
/* https://repl.it/@aneagoie/findNemo1 */

function printAllNumbersThenAllPairSums(numbers) {  // Big O: O(n + n^2) --> O(n^2) --> Quadratic Time

    console.log('these are the numbers:'); //  O(n)
    numbers.forEach(function (number) {
        console.log(number);
    });

    console.log('and these are their sums:'); // O(n ^ 2)
    numbers.forEach(function (firstNumber) {
        numbers.forEach(function (secondNumber) {
            console.log(firstNumber + secondNumber);
        });
    });
}

printAllNumbersThenAllPairSums([1, 2, 3, 4, 5])