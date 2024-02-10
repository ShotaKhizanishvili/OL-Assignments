function personalizedGreeting(name) {
    return `Hello, ${name}!`;
}

const userName = prompt("What's your name?");
const greeting = personalizedGreeting(userName);
console.log(greeting);