
/* https://replit.com/ */
/* https://repl.it/@aneagoie/findNemo1 */

//#1 -- For loop in Javascript.
const nemo = ['nemo'];

function findNemo1(array) { // Big O: O(n) --> Linear Time
    for (let i = 0; i < array.length; i++) {
        if (array[i] === 'nemo') {
            console.log('Found NEMO!');
        }
    }
}

findNemo1(nemo);