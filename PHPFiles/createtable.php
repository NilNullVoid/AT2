<?php
$server_name = "localhost";
$user_name = "root";
$password = "";
$database_name = "ContactsDB";
$connection = mysqli_connect($server_name, $user_name, $password,$database_name);

$sql = "CREATE TABLE Contacts(
cid int,
name varchar(244),
phoneNumber int
)";

if (mysqli_query($connection, $sql)) {
  echo "Table is successfully created in ContactsDB database.";
} else {
  echo "Error:" . mysqli_error($connection);
}
mysqli_close($connection);
?>
