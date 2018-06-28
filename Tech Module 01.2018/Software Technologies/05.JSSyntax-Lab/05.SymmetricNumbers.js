function printSymmetricNums(arr){
    let number = Number(arr[0]);
    let result = ' ';

    for (let i = 1; i <= number; i++) {
         if(isSymmetric(i.toString())){
             result += i + ' ';
         }
    }

    console.log(result.trim());

    function isSymmetric(numAsStr) {
        for (let i = 0; i < numAsStr.length; i++) {
            if(numAsStr[i] != numAsStr[numAsStr.length - i - 1]){
                return false;
            }  
        }

        return true;
    }
}
