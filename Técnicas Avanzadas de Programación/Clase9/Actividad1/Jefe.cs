using System.Collections.Generic;

namespace Clase9
{
    class Jefe : Trabajador
    {
        public List<Trabajador> m_empleados; // Cambiar protected a public

        public Jefe() : base()
        {
            m_empleados = new List<Trabajador>();
        }

        public Jefe(string nombre, string apellido, double sueldo) : base(nombre, apellido, sueldo)
        {
            m_empleados = new List<Trabajador>();
        }

        public void AddEmpleado(Trabajador e)
        {
            m_empleados.Add(e);
        }

        public Trabajador GetEmpleado(int i)
        {
            return m_empleados[i];
        }
    }
}
