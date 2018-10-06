<?php
function printXML($input) {
    $xml = '<?xml version="1.0" encoding="UTF-8"?>' . PHP_EOL . '<quiz>' . PHP_EOL;

    for ($i = 0; $i < count($input); $i += 2){
        $question = $input[$i];
        $answer = $input[$i + 1];

        $xml .= "  <question>
    $question
  </question>
  <answer>
    $answer
  </answer>" . PHP_EOL;
    }

    $xml .= '</quiz>';
    echo $xml;
}

$input = explode(', ', readline());
printXML($input);