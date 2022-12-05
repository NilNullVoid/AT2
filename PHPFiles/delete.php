<?php
$server_name = "localhost";
$user_name = "root";
$password = "";
$database_name = "ContactsDB";
$connection = mysqli_connect($server_name, $user_name, $password,$database_name);

$sql = "DELETE FROM Contacts WHERE cid=".$_GET['cid'];

if (mysqli_query($connection, $sql)) {
  echo "succesfully deleted contact(s).";
} else {
  echo "Error:" . mysqli_error($connection);
}
mysqli_close($connection);
?>
