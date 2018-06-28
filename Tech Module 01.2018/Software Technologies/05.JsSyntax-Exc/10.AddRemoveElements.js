function solve(arr) {
    let numbers = new Array();

    for (let i = 0; i < arr.length; i++) {
        let command = arr[i].split(' ');

        if(command[0] === "add"){
            numbers.push(command[1]);
        }
        else if(Number(command[1] >= 0 && Number(command[1] < numbers.length))){
            numbers.splice(command[1], 1);
        }
    }

    for (let i = 0; i < numbers.length; i++) {
        console.log(numbers[i]);
    }
}