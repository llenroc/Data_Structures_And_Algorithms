
/* https://replit.com/ */
/* https://repl.it/@aneagoie/findNemo1 */

////#1 -- For loop in Javascript.
//const nemo = ['nemo'];

//function findNemo1(array) { // Big O: O(n) --> Linear Time
//    for (let i = 0; i < array.length; i++) {
//        if (array[i] === 'nemo') {
//            console.log('Found NEMO!');
//        }
//    }
//}

//findNemo1(nemo);


const boxes = [1, 2, 3, 4, 5];

function logFirstTwoBoxes(boxes) {  // Big O: O(1) --> Constant Time
    console.log(boxes[0]); // O(1)
    console.log(boxes[1]); // O(1)
}

logFirstTwoBoxes(boxes); // O(2)