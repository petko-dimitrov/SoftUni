function drawChessBoard(n) {
    let result = "<div class=\"chessboard\">\n";
    let color = "";

    for (let row = 0; row < n; row++) {
        if(row %2 === 0) {
            color = "white";
        } else {
            color = "black";
        }
        result += "  <div>\n";

        for (let col = 0; col < n; col++) {
            if(color === "black"){
                color = "white";
            } else {
                color = "black";
            }

            result += `    <span class="${color}"></span>\n`;
        }

        result += "  </div>\n";
    }

    result += "</div>";

    console.log(result);
}

drawChessBoard(2);