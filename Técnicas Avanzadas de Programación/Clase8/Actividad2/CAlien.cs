using System;

namespace Actividad2
{
    class CAlien : CSpaceShip
    {
        protected int velocidad;

        public CAlien(int xInicial, int yInicial)
        {
            x = xInicial;
            y = yInicial;
            velocidad = 0;
        }

        public override void Volar(int desplazamientoX, int desplazamientoY)
        {
            x += desplazamientoX;
            y += desplazamientoY;
        }

        public override void Disparar()
        {
            Console.WriteLine("El alien dispara * en la posición (" + x + ", " + y + ")");
        }

        public override POINT GetXYPos()
        {
            POINT punto;
            punto.x = x;
            punto.y = y;
            return punto;
        }

        public override int GetColision(POINT punto)
        {
            if (x == punto.x && y == punto.y)
                return 1;
            else
                return 0;
        }

        public override void Acelerar(int valor)
        {
            // Acelerar el Alien
            velocidad += valor;
            if (velocidad < -5)
                velocidad = -5;
            else if (velocidad > 5)
                velocidad = 5;

            Console.WriteLine("La velocidad del alien es: " + velocidad);
        }
    }
}
