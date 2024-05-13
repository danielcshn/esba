namespace Clasae10
{
    class CDetail
    {
        private long m_codProducto;
        private string m_descripcion;
        private int m_cantidad;
        private double m_precioUnitario;

        // Funciones de acceso para m_codProducto
        public long CodProducto
        {
            get { return m_codProducto; }
            set { m_codProducto = value; }
        }

        // Funciones de acceso para m_descripcion
        public string Descripcion
        {
            get { return m_descripcion; }
            set { m_descripcion = value; }
        }

        // Funciones de acceso para m_cantidad
        public int Cantidad
        {
            get { return m_cantidad; }
            set { m_cantidad = value; }
        }

        // Funciones de acceso para m_precioUnitario
        public double PrecioUnitario
        {
            get { return m_precioUnitario; }
            set { m_precioUnitario = value; }
        }

        // Constructor
        public CDetail(long codProducto, string descripcion, int cantidad, double precioUnitario)
        {
            m_codProducto = codProducto;
            m_descripcion = descripcion;
            m_cantidad = cantidad;
            m_precioUnitario = precioUnitario;
        }
    }
}
