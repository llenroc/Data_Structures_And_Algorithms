
/* https://replit.com/ */
/* Big O Complexity Chart: https://www.bigocheatsheet.com/ */
/* https://replit.com/@aneagoie/spaceComplexity?language=javascript */


//#5 Space complexity O(1)
function boooo(n) {
    for (let i = 0; i < n; i++) {
        console.log('booooo');
    }
}

boooo([1, 2, 3, 4, 5]);


// #6 Space complexity O(n)
function arrayOfHiNTimes(n) {
    var hiArray = [];
    for (let i = 0; i < n; i++) {
        hiArray[i] = 'hi';
    }
    return hiArray;
}

arrayOfHiNTimes(6)