<?php
function mostrarTablasMultiplicar() {
    for ($i = 0; $i <= 10; $i++) {
        echo "<h3>Tabla del $i:</h3>";
        for ($j = 0; $j <= 10; $j++) {
            $resultado = $i * $j;
            echo "$i x $j = $resultado<br>";
        }
        echo "<br>";
    }
}

mostrarTablasMultiplicar();
?>