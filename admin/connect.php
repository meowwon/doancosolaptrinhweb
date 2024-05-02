<?php
$server = 'localhost';
$user = 'root';
$pass = '';
$database = 'booksrore';

$conn = new mysqLi($server, $user, $pass, $database);
if ($conn) {
    mysqLi_query($conn, "SET NAMES 'utf8' ");
    echo 'da ket noi';
} else {
    echo 'ket noi that bai';
}
