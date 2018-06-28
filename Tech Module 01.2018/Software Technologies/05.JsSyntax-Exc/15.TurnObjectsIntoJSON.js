function turnIntoJSON(arr) {

    let student = {};

    for (let i = 0; i < arr.length; i++) {
        let line = arr[i].split(' -> ');

        if(isNaN(line[1])){
            student[line[0]] = line[1];
        } else{
            student[line[0]] = Number(line[1]);
        }

    }

    let str = JSON.stringify(student);
    console.log(str);
}