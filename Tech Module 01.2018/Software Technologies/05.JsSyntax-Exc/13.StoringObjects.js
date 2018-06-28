function store(arr) {

    let students = [];

    for (let i = 0; i < arr.length; i++) {
        let line = arr[i].split(' -> ');

        let student = {};
        student.name = line[0];
        student.age = Number(line[1]);
        student.grade = Number(line[2]);
        students.push(student);
    }

    for (let student of students) {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Grade: ${student.grade.toFixed(2)}`);
    }
}