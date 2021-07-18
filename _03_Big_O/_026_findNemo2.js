
/* https://replit.com/ */
/* Big O Complexity Chart: https://www.bigocheatsheet.com/ */
/* https://repl.it/@aneagoie/findingNemo2 */

//#1 -- For loop in Javascript.
const fish = ['dory', 'bruce', 'marlin', 'nemo'];
const nemo = ['nemo'];
const everyone = ['dory', 'bruce', 'marlin', 'nemo', 'gill', 'bloat', 'nigel', 'squirt', 'darla', 'hank'];
const large = new Array(10).fill('nemo');

function findNemo2(fish) { // Big O: O(n) --> Linear Time
    let t0 = performance.now();
    for (let i = 0; i < fish.length; i++) {
        if (fish[i] === 'nemo') {
            console.log('Found NEMO!');
        }
    }
    let t1 = performance.now();
    console.log("Call to find Nemo took " + (t1 - t0) + " milliseconds.");
}

findNemo2(everyone)