using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Empleado
    {
        private string nombre;
        private double salario;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nombre = value;
                }
            }
        }
        public double Salario
        {
            get { return salario; }
            set
            {
                if (value >= 0)
                {
                    salario = value;
                }
            }
        }
    }

    public class CuentaBancaria
    {
        private double saldo;
        public int limite = 2000;

        public CuentaBancaria(double Saldo)
        {
            saldo = Saldo;
        }

        public void Retirar(double monto)
        {
            if (monto <= saldo)
            {
                saldo -= monto;
                Console.WriteLine($"Retiro realizado correctamente");
            }
            else if (monto > limite)
            {
                Console.WriteLine($"No es posible retirar Q{monto}, ya que el limite de retiro diario es de {limite}. ");
            }
        }

        public double MostrarSaldo()
        {
            return saldo;
        }
    }

    public class Vehiculo
    {
        private bool encendido = false;

        public void Encender(string comando)
        {
            if (comando == "Encender")
            {
                if (!encendido)
                {
                    encendido = true;
                    Console.WriteLine("El vehiculo se ha encendido");
                }
                else
                {
                    Console.WriteLine("El vehiculo ya esta encendido");
                }
            }
            else if (comando == "Apagar")
            {
                if (encendido)
                {
                    encendido = false;
                    Console.WriteLine("El vehiculo se ha apagado");
                }
                else
                {
                    Console.WriteLine("El vehiculo ya esta apagado");
                }
            }
            else
            {
                Console.WriteLine("Comando no valido");
            }
        }
    }
}

