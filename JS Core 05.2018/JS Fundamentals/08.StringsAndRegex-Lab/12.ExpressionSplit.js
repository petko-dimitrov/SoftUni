function splitExpr(expression) {
    let tokens = expression.split(/[\s'.,;()]+/g);
    console.log(tokens.join('\n'));
}

splitExpr('let sum = 4 * 4,b = "wow";');