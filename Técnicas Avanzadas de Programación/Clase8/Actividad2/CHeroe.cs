using System;

namespace Actividad2
{
    class CHeroe : CSpaceShip
    {
        public CHeroe(int xInicial, int yInicial)
        {
            x = xInicial;
            y = yInicial;
        }

        public override void Volar(int desplazamientoX, int desplazamientoY)
        {
            // El héroe solo vuela hacia los lados
            x += desplazamientoX;
        }

        public override void Disparar()
        {
            Console.WriteLine("El héroe dispara | en la posición (" + x + ", " + y + ")");
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
            // El héroe no acelera
        }
    }
}
