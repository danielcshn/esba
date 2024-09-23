<?php
$destinatario = "correo@yahoo.com.ar";
$asunto = "Consulta enviada por la web";
$cuerpo = $_POST ['consulta'];
mail($destinatario, $asunto, $cuerpo);
echo "Gracias por enviar el comentario a:
".$destinatario.", con el asunto: ".$asunto." y su
mensaje es: ".$cuerpo;
?>