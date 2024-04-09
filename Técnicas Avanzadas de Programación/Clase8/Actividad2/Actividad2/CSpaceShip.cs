using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    public struct POINT
    {
        public int x;
        public int y;
    }

    abstract class CSpaceShip
    {
        protected int x;
        protected int y;

        public abstract void Volar(int desplazamientoX, int desplazamientoY);
        public abstract void Disparar();
        public abstract POINT GetXYPos();
        public abstract int GetColision(POINT punto);
        public abstract void Acelerar(int valor);
    }
}
