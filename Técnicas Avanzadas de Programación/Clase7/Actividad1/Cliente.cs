using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    class Cliente
    {
        // Datos miembros protegidos
        protected long NumeroCuenta;
        protected string Apellido;
        protected string Nombre;
        protected string Direccion;
        protected string FechaNac;
        protected double Saldo;

        // Constructor
        public Cliente(long numeroCuenta, string apellido, string nombre, string direccion, string fechaNac, double saldoInicial)
        {
            NumeroCuenta = numeroCuenta;
            Apellido = apellido;
            Nombre = nombre;
            Direccion = direccion;
            FechaNac = fechaNac;
            Saldo = saldoInicial;
        }

        // Funciones miembro públicas
        public void PonerApellido(string apellido)
        {
            Apellido = apellido;
        }

        public string ObtenerApellido()
        {
            return Apellido;
        }

        public void PonerNombre(string nombre)
        {
            Nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }

        public void PonerDireccion(string direccion)
        {
            Direccion = direccion;
        }

        public string ObtenerDireccion()
        {
            return Direccion;
        }

        public void PonerFechaNac(string fechaNac)
        {
            FechaNac = fechaNac;
        }

        public string ObtenerFechaNac()
        {
            return FechaNac;
        }

        public double ObtenerSaldo()
        {
            return Saldo;
        }

        public double Depositar(double monto)
        {
            Saldo += monto;
            return Saldo;
        }

        public double Retirar(double monto)
        {
            if (Saldo >= monto)
            {
                Saldo -= monto;
                return Saldo;
            }
            else
            {
                return -1;
            }
        }
    }
}
