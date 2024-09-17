<?php
// Definir un array asociativo para los clientes
$clientes = [
    [
        "Número" => 1,
        "Nombre" => "Juan Pérez",
        "Dirección" => "Calle 123, Ciudad A",
        "Email" => "juan.perez@example.com",
        "Teléfono" => "555-1234"
    ],
    [
        "Número" => 2,
        "Nombre" => "Ana Gómez",
        "Dirección" => "Avenida 456, Ciudad B",
        "Email" => "ana.gomez@example.com",
        "Teléfono" => "555-5678"
    ],
    [
        "Número" => 3,
        "Nombre" => "Carlos Fernández",
        "Dirección" => "Calle 789, Ciudad C",
        "Email" => "carlos.fernandez@example.com",
        "Teléfono" => "555-7890"
    ],
    [
        "Número" => 4,
        "Nombre" => "Empresa XYZ",
        "Dirección" => "Avenida 101, Ciudad D",
        "Email" => "contacto@xyz.com",
        "Teléfono" => "555-1010"
    ],
    [
        "Número" => 5,
        "Nombre" => "María López",
        "Dirección" => "Boulevard 202, Ciudad E",
        "Email" => "maria.lopez@example.com",
        "Teléfono" => "555-2020"
    ]
];

// Generar la tabla HTML para mostrar la información de los clientes
echo "<table border='1'>
        <tr>
            <th>Número</th>
            <th>Nombre o Razón Social</th>
            <th>Dirección</th>
            <th>Email</th>
            <th>Teléfono</th>
        </tr>";

// Iterar sobre el array para llenar los datos en la tabla
foreach ($clientes as $cliente) {
    echo "<tr>";
    echo "<td>{$cliente['Número']}</td>";
    echo "<td>{$cliente['Nombre']}</td>";
    echo "<td>{$cliente['Dirección']}</td>";
    echo "<td>{$cliente['Email']}</td>";
    echo "<td>{$cliente['Teléfono']}</td>";
    echo "</tr>";
}

echo "</table>";
?>
