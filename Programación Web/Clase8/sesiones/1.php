<?php
	SESSION_START();
	
	$nombre = $_POST['nombre'];
	echo "Mi nombre por POST es:".$nombre."<br><br>";
	$_SESSION['nombre'] = $nombre;
	echo "Mi nombre por SESSION es:	".$_SESSION['nombre']."<br><br>";
	echo '
	<form action="3.php" method="POST" >
	<select name="bebidas">
	<label>Seleccione la bebida: </label>
	<option>Gaseosa</option>
	<option>Vino</option>
	<option>Cerveza</option>
	</select>
	<input type="submit" value="Siguiente">
	</form><br>
	<a href="1.php">volver</a>
	';
?>