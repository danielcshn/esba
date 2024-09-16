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
echo'
<table border="1" width= "300px">
<tr>
<td>
Nombre:
</td>
<td>'.$agenda[$numero]['Nombre'].'</td>
</tr>
 <tr>
<td>
Teléfono:
</td>
<td>'.$agenda[$numero]['Telefono'].'</td>
</tr>
<tr>
<td>
Mail:
</td>
<td>'.$agenda[$numero]['Mail'].'</td>
</tr>
</table>
';
}
?>