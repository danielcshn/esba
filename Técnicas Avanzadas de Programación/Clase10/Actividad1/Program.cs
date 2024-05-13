using System;

namespace Clasae10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de CHeader
            CHeader header = new CHeader("12345", DateTime.Now, "Empresa ABC", "Calle Principal 123", "123456789", "12345", "Tipo A", DateTime.Now.AddYears(-5), "12345678");

            // Crear una instancia de CDetail
            CDetail detail = new CDetail(1, "Producto 1", 2, 10.5);

            // Crear una instancia de CFooter
            CFooter footer = new CFooter(21.0, 25.0, 4.0, 1.0);

            // Ejemplo de acceso a los campos y funciones de las clases
            Console.WriteLine($"Número de factura: {header.NFactura}");
            Console.WriteLine($"Descripción del producto: {detail.Descripcion}");
            Console.WriteLine($"Subtotal: {footer.SubTotal}");

            // Modificar valores
            header.NFactura = "54321";
            detail.Cantidad = 3;
            footer.Total = 30.0;
        }
    }
}
