<?php
$server_name = "localhost";
$user_name = "root";
$password = "";
$database_name = "ContactsDB";
$connection = mysqli_connect($server_name, $user_name, $password,$database_name);

$sql = "SELECT * FROM Contacts WHERE cid=".$_GET['cid'];
$result = mysqli_query($connection, $sql);

if (mysqli_num_rows($result) > 0) {
  // output data of each row
  while($row = mysqli_fetch_assoc($result)) {
    echo $row["cid"]. ":" . $row["name"]. ":" . $row["phoneNumber"]."\n";
  }
} else {
  echo "No results.";
}
mysqli_close($connection);
?>
