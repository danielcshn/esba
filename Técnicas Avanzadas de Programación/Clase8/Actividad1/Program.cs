using System;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia de Arquero
            Arquero arquero = new Arquero("Roberto Abbondanzieri", 1, 85, 65, 0, 0);

            // Ejemplificar métodos
            Console.WriteLine("Nombre del arquero: " + arquero.ObtenerNombre());
            Console.WriteLine("Habilidad del arquero: " + arquero.ObtenerHabilidad());
            Console.WriteLine("Velocidad del arquero: " + arquero.ObtenerVelocidad());

            arquero.Mover(10, 5);
            Console.WriteLine("Nueva ubicación del arquero - X: " + arquero.ObtenerX() + ", Y: " + arquero.ObtenerY());

            arquero.Patear(8);

            arquero.TomarConLasManos();
        }
    }
}
