<html>
<body bgcolor="#000000">
<?php

$dbhost = 'sql109.byethost14.com';
$dbuser = 'b14_7319697';
$dbpass = 'lladika0';
$dbname = 'b14_7319697_xhelati';
$emri = $_GET["emri"];
$poenat = $_GET["poenat"];

$conn = mysql_connect($dbhost, $dbuser, $dbpass) or die ('Loja nuk mundi te kyqet ne Databaze');

mysql_select_db($dbname) or die ('Loja nuk mundi zgjedh Databazen');

$query = "INSERT INTO loja(Emri, Poenat) VALUES ('".$emri."', '".$poenat."')";

mysql_query($query) or die ('Loja nuk mundi te bej Update Databazen');

echo "SUKSES";

mysql_close($conn);

?>
</html>