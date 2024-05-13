namespace Clasae10
{
    class CFooter
    {
        private double m_subTotal;
        private double m_total;
        private double m_iva;
        private double m_descuento;

        // Funciones de acceso para m_subTotal
        public double SubTotal
        {
            get { return m_subTotal; }
            set { m_subTotal = value; }
        }

        // Funciones de acceso para m_total
        public double Total
        {
            get { return m_total; }
            set { m_total = value; }
        }

        // Funciones de acceso para m_iva
        public double IVA
        {
            get { return m_iva; }
            set { m_iva = value; }
        }

        // Funciones de acceso para m_descuento
        public double Descuento
        {
            get { return m_descuento; }
            set { m_descuento = value; }
        }

        // Constructor
        public CFooter(double subTotal, double total, double iva, double descuento)
        {
            m_subTotal = subTotal;
            m_total = total;
            m_iva = iva;
            m_descuento = descuento;
        }
    }
}
