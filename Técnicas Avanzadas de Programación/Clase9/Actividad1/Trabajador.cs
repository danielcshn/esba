namespace Clase9
{

    class Trabajador
    {
        protected string Nombre;
        protected string Apellido;
        protected double sueldo;

        public Trabajador()
        {
            Nombre = "";
            Apellido = "";
            sueldo = 0;
        }

        public Trabajador(string nombre, string apellido, double sueldo)
        {
            Nombre = nombre;
            Apellido = apellido;
            this.sueldo = sueldo;
        }

        public virtual void SetSueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }

        public virtual double GetSueldo()
        {
            return sueldo;
        }

        public void SetApellido(string ape)
        {
            Apellido = ape;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }

}
