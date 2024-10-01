<?php
	SESSION_START();
	$_SESSION['bebida'] = $_POST['bebidas'];
	echo "Mi nombre sigue siendo: ".$_SESSION['nombre']."<br> y elegí: ".$_SESSION['bebida'] ;
	SESSION_DESTROY();
?>