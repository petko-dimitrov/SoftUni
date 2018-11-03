<?php
if (isset($_SESSION['messages'])) {
    echo '<ul id="messages">';
    foreach ($_SESSION['messages'] as $message) {
        echo '<li class="' . $message['type'] . '">';
        echo htmlspecialchars($message['msg']);
        echo '</li>';
    }
    unset($_SESSION['messages']);
}