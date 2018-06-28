function Calculator(leftOperand, operator, rightOperand) {
    this.leftOperand = leftOperand;
    this.operator = operator;
    this.rightOperand = rightOperand;

    this.calculateResult = function () {
        let result = 0;

        if(isNaN(this.leftOperand) || isNaN(this.rightOperand)){
            result = "Enter valid numbers!";
        } else {
            switch(this.operator){
                case '+':
                    result = this.leftOperand + this.rightOperand;
                    break;
                case '-':
                    result = this.leftOperand - this.rightOperand;
                    break;
                case '*':
                    result = this.leftOperand * this.rightOperand;
                    break;
                case '/':
                    result = this.leftOperand / this.rightOperand;
                    break;
                case '^':
                    result = Math.pow(this.leftOperand, this.rightOperand);
                    break;
                case '%':
                    result = this.leftOperand % this.rightOperand;
                    break;
            }
        }

        return result;
    }
}

module.exports = Calculator;