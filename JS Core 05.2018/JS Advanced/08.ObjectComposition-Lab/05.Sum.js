function solve() {
    let num1, num2, result;

    function init(sel1, sel2, resultSel) {
        num1 = $(sel1);
        num2 = $(sel2);
        result = $(resultSel);
    }
    
    function add() {
        let sum = Number(num1.val()) + Number(num2.val());
        result.val(sum);
    }
    
    function subtract() {
        let diff = Number(num1.val()) - Number(num2.val());
        result.val(diff);
    }

    return { init, add, subtract };
}