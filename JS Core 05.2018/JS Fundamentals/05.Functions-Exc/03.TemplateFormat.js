function printQuiz(input) {
    let result = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<quiz>\n";

    for (let i = 0; i < input.length; i+=2) {
        let question = input[i];
        let answer = input[i+1];

        result += `\t<question>\n\t\t${question}\n\t</question>\n\t<answer>\n\t\t${answer}\n\t</answer>\n`;
    }

    result += "</quiz>";
    console.log(result);
}

printQuiz(["Dry ice is a frozen form of which gas?",
    "Carbon Dioxide",
    "What is the brightest star in the night sky?",
    "Sirius"]);