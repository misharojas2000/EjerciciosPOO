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
            set { if (string.IsNullOrWhiteSpace(value)){
                    nombre = value;
                }
            } }
        public double Salario
        {
            get { return salario; }
            set
            {
                if(value >= 0)
                {
                    salario= value;
                }
            }
        }
    }

    public class CuentaBancaria
    {
        private double saldo;
        public int limite = 1000;

        public CuentaBancaria(double Saldo)
        {
            saldo = Saldo;
        }

        public void Retirar(double monto)
        {
            if (monto <= saldo)
            {
                saldo -= monto;
            } else if (monto > limite)
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
        public bool encendido = true;
        public bool apagado = false;
    }

}
