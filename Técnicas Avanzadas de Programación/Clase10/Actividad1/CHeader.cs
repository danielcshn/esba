using System;

namespace Clasae10
{
    class CHeader
    {
        private string m_nFactura;
        private DateTime m_fechaEmision;
        private string m_RazonSocial;
        private string m_Domicilio;
        private string m_Cuit;
        private string m_IngresosBrutos;
        private string m_Tipo;
        private DateTime m_fechaIncioActividad;
        private string m_dni;

        // Funciones de acceso para m_nFactura
        public string NFactura
        {
            get { return m_nFactura; }
            set { m_nFactura = value; }
        }

        // Funciones de acceso para m_fechaEmision
        public DateTime FechaEmision
        {
            get { return m_fechaEmision; }
            set { m_fechaEmision = value; }
        }

        // Resto de funciones de acceso para los demás campos (m_RazonSocial, m_Domicilio, etc.)
        // ...

        // Constructor
        public CHeader(string nFactura, DateTime fechaEmision, string razonSocial, string domicilio, string cuit, string ingresosBrutos, string tipo, DateTime fechaIncioActividad, string dni)
        {
            m_nFactura = nFactura;
            m_fechaEmision = fechaEmision;
            m_RazonSocial = razonSocial;
            m_Domicilio = domicilio;
            m_Cuit = cuit;
            m_IngresosBrutos = ingresosBrutos;
            m_Tipo = tipo;
            m_fechaIncioActividad = fechaIncioActividad;
            m_dni = dni;
        }
    }
}
