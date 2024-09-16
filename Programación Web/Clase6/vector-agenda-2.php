<?php
$agenda[0]['Nombre']= "María";
$agenda[0]['Telefono']= "1234";
$agenda[0]['Mail']= "maria@yahoo.com";
$agenda[1]['Nombre']= "Daniel";
$agenda[1]['Telefono']= "1234";
$agenda[1]['Mail']= "dany@yahoo.com";
$agenda[2]['Nombre']= "Margarita";
$agenda[2]['Telefono']= "1234";
$agenda[2]['Mail']= "marga@yahoo.com";
for ($numero=0; $numero<=2; $numero++){
echo $agenda[$numero]['Nombre']."<br>";
echo $agenda[$numero]['Telefono']."<br>";
echo $agenda[$numero]['Mail']."<br>";
}
?>