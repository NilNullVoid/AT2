<?php
$server_name = "localhost";
$user_name = "root";
$password = "";
$database_name = "ContactsDB";
$connection = mysqli_connect($server_name, $user_name, $password,$database_name);

$sql = "INSERT INTO Contacts
  (cid, name, phoneNumber)
  VALUES (".$_GET['cid'].", '".$_GET['name']."', ".$_GET['number'].")";

if (mysqli_query($connection, $sql)) {
  echo "succesfully created contact.";
} else {
  echo "Error:" . mysqli_error($connection);
}
mysqli_close($connection);
?>
