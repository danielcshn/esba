<?php
// Definir un array asociativo para las frutas
$frutas = [
    "Manzana" => ["Color" => "Rojo", "Sabor" => "Dulce", "Forma" => "Redonda"],
    "Naranja" => ["Color" => "Naranja", "Sabor" => "Ácido", "Forma" => "Redonda"],
    "Pera" => ["Color" => "Verde", "Sabor" => "Dulce", "Forma" => "Ovalada"]
];

// Generar la tabla HTML
echo "<table border='1'>
        <tr>
            <th>FRUTA</th>
            <th>Color</th>
            <th>Sabor</th>
            <th>Forma</th>
        </tr>";

// Iterar sobre el array para llenar los datos en la tabla
foreach ($frutas as $fruta => $atributos) {
    echo "<tr>";
    echo "<td>$fruta</td>";
    echo "<td>{$atributos['Color']}</td>";
    echo "<td>{$atributos['Sabor']}</td>";
    echo "<td>{$atributos['Forma']}</td>";
    echo "</tr>";
}

echo "</table>";
?>
