using System;

namespace Actividad1
{
    class Jugador
    {
        // Atributos
        protected string nombre;
        protected int numero;
        protected int habilidad;
        protected int velocidad;
        protected int x; // Modificado para ser accesible a clases derivadas
        protected int y; // Modificado para ser accesible a clases derivadas

        // Constructor
        public Jugador(string nombre, int numero, int habilidad, int velocidad, int x, int y)
        {
            this.nombre = nombre;
            this.numero = numero;
            this.habilidad = habilidad;
            this.velocidad = velocidad;
            this.x = x;
            this.y = y;
        }

        // Métodos
        public int ObtenerHabilidad()
        {
            return habilidad;
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public void Mover(int desplazamientoX, int desplazamientoY)
        {
            x += desplazamientoX;
            y += desplazamientoY;
        }

        public void Patear(int fuerza)
        {
            if (fuerza >= 1 && fuerza <= 3)
            {
                Console.WriteLine("Disparo débil");
            }
            else if (fuerza >= 4 && fuerza <= 8)
            {
                Console.WriteLine("Disparo medio");
            }
            else if (fuerza >= 9 && fuerza <= 10)
            {
                Console.WriteLine("Disparo potente");
            }
        }
    }
}
