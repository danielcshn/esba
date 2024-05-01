using System;

namespace Actividad1
{
    class Arquero : Jugador
    {
        // Constructor
        public Arquero(string nombre, int numero, int habilidad, int velocidad, int x, int y) : base(nombre, numero, habilidad, velocidad, x, y)
        {
        }

        // Método adicional para el arquero
        public void TomarConLasManos()
        {
            Console.WriteLine("El arquero toma el balón");
        }

        // Acceso a x e y
        public int ObtenerX()
        {
            return x;
        }

        public int ObtenerY()
        {
            return y;
        }
    }
}
