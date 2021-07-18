
/* https://replit.com/ */
/* Big O Complexity Chart: https://www.bigocheatsheet.com/ */
/* https://replit.com/@aneagoie/logAllPairsOfArray?language=javascript */

//Log all pairs of array

const boxes = ['a', 'b', 'c', 'd', 'e'];
function logAllPairsOfArray(array) { // Big O: O(n * n) or O(n^2) --> Quadratic Time
    for (let i = 0; i < array.length; i++) {
        for (let j = 0; j < array.length; j++) {
            console.log(array[i], array[j])
        }
    }
}

logAllPairsOfArray(boxes);