let y = Math.floor(Math.random() * 10 + 1);
 
let guess = 1;

document.getElementById("submitguess").onclick = function () {
    let x = document.getElementById("guessField").value;

    if (x == y) {
        alert("You are right "
            + guess + " guess needed ");
    }

    else if (x > y) {
        guess++;
        alert("too high");
    }
    else {
        guess++;
        alert("too low")
    }
}