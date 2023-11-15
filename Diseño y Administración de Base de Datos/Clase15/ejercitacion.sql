/*

De las tablas:
CLIENTE(codigo,nombre,domicilio,provincia)
PRODUCTO(codigo_producto,nombre_producto)
ITEM_VENTAS(número_factura,codigo_producto,cantidad,precio)
VENTAS(numero_factura,codigo_cliente,fecha)

*/

-- 1. Obtener el nombre y el domicilio de los clientes que viven en la provincia de Misiones.
SELECT nombre, domicilio
FROM CLIENTE
WHERE provincia = 'Misiones';

-- 2. Obtener el nombre, domicilio y provincia de los clientes que viven en la provincia de Misiones o de Rio Negro.
SELECT nombre, domicilio, provincia
FROM CLIENTE
WHERE provincia IN ('Misiones', 'Rio Negro');

-- 3. Obtener el importe total en pesos por factura y producto, especificando el numero de factura, el código del producto y el importe total.
SELECT numero_factura, codigo_producto, SUM(cantidad * precio) AS importe_total
FROM ITEM_VENTAS
GROUP BY numero_factura, codigo_producto;

-- 4. Sobre la consulta 3, obtener solo el importe total para el producto a.
SELECT SUM(cantidad * precio) AS importe_total_producto_a
FROM ITEM_VENTAS
WHERE codigo_producto = 'a';

-- 5. Sobre la consulta 3, obtener solo el importe total para las facturas mayores iguales a 2 y menores iguales a 5 y solo para el producto código c.
SELECT SUM(cantidad * precio) AS importe_total_facturas_2_a_5_producto_c
FROM ITEM_VENTAS
WHERE numero_factura BETWEEN 2 AND 5
AND codigo_producto = 'c';

-- 6. Sobre la consulta 3, obtener solo el importe total para los registros cuyo importe total sea mayor a 200.
SELECT numero_factura, codigo_producto, SUM(cantidad * precio) AS importe_total
FROM ITEM_VENTAS
GROUP BY numero_factura, codigo_producto
HAVING SUM(cantidad * precio) > 200;

-- 7. Obtener un listado de las facturas realizadas especificando número de factura, nombre del producto y cantidad vendida.
SELECT IV.numero_factura, P.nombre_producto, IV.cantidad
FROM ITEM_VENTAS IV
JOIN PRODUCTO P ON IV.codigo_producto = P.codigo_producto;

-- 8. Obtener un listado de las facturas realizadas cuya cantidad sea mayor igual a 15 especificando numero de factura, nombre del producto y cantidad vendida.
SELECT IV.numero_factura, P.nombre_producto, IV.cantidad
FROM ITEM_VENTAS IV
JOIN PRODUCTO P ON IV.codigo_producto = P.codigo_producto
WHERE IV.cantidad >= 15;

-- 9. Obtener un listado de las facturas realizadas indicando número de factura, nombre del cliente, nombre del producto, cantidad y precio y el importe total.
SELECT V.numero_factura, C.nombre, P.nombre_producto, IV.cantidad, IV.precio, (IV.cantidad * IV.precio) AS importe_total
FROM VENTAS V
JOIN CLIENTE C ON V.codigo_cliente = C.codigo
JOIN ITEM_VENTAS IV ON V.numero_factura = IV.numero_factura
JOIN PRODUCTO P ON IV.codigo_producto = P.codigo_producto;

-- 10. Obtener la cantidad de unidades máxima
SELECT MAX(cantidad) AS cantidad_maxima
FROM ITEM_VENTAS;

-- 11. Obtener la cantidad total de unidades vendidas del producto c.
SELECT SUM(cantidad) AS cantidad_total_c
FROM ITEM_VENTAS
WHERE codigo_producto = 'c';

-- 12. Cantidad de unidades vendidas por producto, indicando la descripción del producto, ordenado de mayor a menor por las cantidades vendidas.
SELECT P.nombre_producto, SUM(IV.cantidad) AS total_unidades_vendidas
FROM ITEM_VENTAS IV
JOIN PRODUCTO P ON IV.codigo_producto = P.codigo_producto
GROUP BY P.nombre_producto
ORDER BY total_unidades_vendidas DESC;

-- 13. Cantidad de unidades vendidas por producto, indicando la descripción del producto, ordenado alfabéticamente por nombre de producto para los productos que vendieron más de 30 unidades.
SELECT P.nombre_producto, SUM(IV.cantidad) AS total_unidades_vendidas
FROM ITEM_VENTAS IV
JOIN PRODUCTO P ON IV.codigo_producto = P.codigo_producto
GROUP BY P.nombre_producto
HAVING SUM(IV.cantidad) > 30
ORDER BY P.nombre_producto;

-- 14. Obtener cuantas compras (1 factura = 1 compra) realizo cada cliente indicando el código y nombre del cliente ordenado de mayor a menor.
SELECT V.codigo_cliente, C.nombre, COUNT(V.numero_factura) AS compras_realizadas
FROM VENTAS V
JOIN CLIENTE C ON V.codigo_cliente = C.codigo
GROUP BY V.codigo_cliente, C.nombre
ORDER BY compras_realizadas DESC;

-- 15. Promedio de unidades vendidas por producto, indicando el código del producto para el cliente 1.
SELECT IV.codigo_producto, AVG(IV.cantidad) AS promedio_unidades_vendidas
FROM ITEM_VENTAS IV
JOIN VENTAS V ON IV.numero_factura = V.numero_factura
WHERE V.codigo_cliente = 1
GROUP BY IV.codigo_producto;

-- 16. Cantidad de unidades vendidas por cliente y producto, indicando el nombre del cliente, la descripción del producto para los productos que vendieron entre 15 y 35 unidades.
SELECT C.nombre, P.nombre_producto, SUM(IV.cantidad) AS total_unidades_vendidas
FROM ITEM_VENTAS IV
JOIN VENTAS V ON IV.numero_factura = V.numero_factura
JOIN CLIENTE C ON V.codigo_cliente = C.codigo
JOIN PRODUCTO P ON IV.codigo_producto = P.codigo_producto
WHERE IV.cantidad BETWEEN 15 AND 35
GROUP BY C.nombre, P.nombre_producto;
