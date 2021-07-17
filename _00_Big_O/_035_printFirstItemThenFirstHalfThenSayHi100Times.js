
/* https://replit.com/ */
/* Big O Complexity Chart: https://towardsdatascience.com/understanding-time-complexity-with-python-examples-2bda6e8158a7 */
/* https://repl.it/@aneagoie/printFirstItemThenFirstHalfThenSayHi100Times?language=javascript */
/* big o complexity rules */

function printFirstItemThenFirstHalfThenSayHi100Times(items) {
    console.log(items[0]);

    var middleIndex = Math.floor(items.length / 2);
    var index = 0;

    while (index < middleIndex) {
        console.log(items[index]);
        index++;
    }

    for (var i = 0; i < 100; i++) {
        console.log('hi');
    }
}