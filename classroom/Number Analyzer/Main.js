function numberAnalyzer(numbers) {
    let sum = 0;
    for (let i = 0; i < numbers.length; i++) {
        sum += numbers[i];
    }

    let max = numbers[0];
    let min = numbers[0];
    for (let i = 1; i < numbers.length; i++) {
        if (numbers[i] > max) {
            max = numbers[i];
        }
        if (numbers[i] < min) {
            min = numbers[i];
        }
    }

    let evenNumbers = [];
    let oddNumbers = [];
    for (let i = 0; i < numbers.length; i++) {
        if (numbers[i] % 2 === 0) {
            evenNumbers.push(numbers[i]);
        } else {
            oddNumbers.push(numbers[i]);
        }
    }

    return {
        sum: sum,
        max: max,
        min: min,
        evenNumbers: evenNumbers,
        oddNumbers: oddNumbers
    };
}

const numbers = [5, 10, 3, 8, 15, 20];
const analysisResult = numberAnalyzer(numbers);
console.log("Sum:", analysisResult.sum);
console.log("Maximum:", analysisResult.max);
console.log("Minimum:", analysisResult.min);
console.log("Even Numbers:", analysisResult.evenNumbers);
console.log("Odd Numbers:", analysisResult.oddNumbers);
