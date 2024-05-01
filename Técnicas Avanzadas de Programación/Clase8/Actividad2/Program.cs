using System;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de las clases
            CHeroe heroe = new CHeroe(0, 0);
            CAlien alien = new CAlien(10, 10);

            // Volar
            heroe.Volar(5, 0);
            alien.Volar(-3, 2);

            // Disparar
            heroe.Disparar();
            alien.Disparar();

            // Obtener posición
            POINT posHeroe = heroe.GetXYPos();
            POINT posAlien = alien.GetXYPos();
            Console.WriteLine("Posición del héroe: (" + posHeroe.x + ", " + posHeroe.y + ")");
            Console.WriteLine("Posición del alien: (" + posAlien.x + ", " + posAlien.y + ")");

            // Acelerar
            alien.Acelerar(3);
        }
    }
}
