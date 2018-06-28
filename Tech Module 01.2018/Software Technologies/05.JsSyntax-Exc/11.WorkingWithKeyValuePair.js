function solve(arr) {
    let obj = {};

    for (let i = 0; i < arr.length - 1; i++) {
        let line = arr[i].split(' ')
        let key = line[0];
        let value = line[1];

        obj[key] = value;
    }

    if(arr[arr.length - 1] in obj){
        console.log(obj[arr[arr.length - 1]]);
    } else{
       console.log('None');
    }
}