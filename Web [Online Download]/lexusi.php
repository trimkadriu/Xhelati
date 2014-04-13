<html>
<?php

$dbhost = 'sql109.byethost14.com';
$dbuser = 'b14_7319697';
$dbpass = 'lladika0';
$dbname = 'b14_7319697_xhelati';
$conn = mysql_connect($dbhost, $dbuser, $dbpass) or die ('Loja nuk mundi te kyqet ne Databaze');

mysql_select_db($dbname) or die ('Loja nuk mundi zgjedh Databazen');

$query = "SELECT Pozita, Emri, Poenat  FROM (SELECT ID, @counter:=@counter+1 as Pozita, Emri, Poenat from loja, (SELECT @counter:=0) as Pozita order by Poenat desc) as t";

$rezultati = mysql_query($query) or die (mysql_error());

echo "<table>";
echo "<tr><td bgcolor='#999999'>Pozita</td><td bgcolor='#999999'>Emri</td><td bgcolor='#999999'>Poenat</td></tr>";

while($row = mysql_fetch_array($rezultati))
  {
  echo "<tr><td>" . $row['Pozita'] . "</td><td>" . $row['Emri'] . "</td><td>" . $row['Poenat'];
  echo "</tr>";
  }

echo "</table>";

mysql_close($conn);

?>
</html>