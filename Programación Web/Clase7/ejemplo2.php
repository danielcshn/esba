<?php

function encabezadoPagina($titulo){
	$encabezado="<html><head><title>$titulo</title></head>";
	echo $encabezado;
}

$titulo="PROGRAMACIÓN V";
encabezadoPagina($titulo);

?>