-- Crear una base de datos llamada RRHH:
CREATE DATABASE RRHH;

-- Crear la tabla empleados con los campos DNI numérico de 8, nombre carácter de 50, apellido carácter 50:
CREATE TABLE empleados (
    DNI NUMERIC(8),
    nombre VARCHAR(50),
    apellido VARCHAR(50)
);

-- Modificar la tabla empleados y agregar la columna teléfono numérico de 20:
ALTER TABLE empleados
ADD telefono NUMERIC(20);

-- Modificar la tabla empleados y definir el campo DNI como clave primaria:
ALTER TABLE empleados
ADD PRIMARY KEY (DNI);

-- Crear la tabla salarios con los campos categoría carácter de 50, descripción carácter de 50, importe decimal de 8 enteros y 2 decimales:
CREATE TABLE salarios (
    categoria VARCHAR(50),
    descripcion VARCHAR(50),
    importe DECIMAL(8,2)
);

-- Borrar la columna descripción de la tabla salarios:
ALTER TABLE salarios
DROP COLUMN descripcion;

-- Borrar las tablas empleados y salarios:
DROP TABLE empleados;
DROP TABLE salarios;

-- Borrar la base de datos RRHH:
DROP DATABASE RRHH;
