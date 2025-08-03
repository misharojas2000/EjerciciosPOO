using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioHerencia
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public void Trabajar()
        {
            Console.WriteLine($"{Nombre} trabaja en la empresa.");
        }
    }

    public class Gerente : Empleado
    {
        public Gerente(string nombre) : base(nombre)
        {
        }

        public void TomarDecision()
        {
            Console.WriteLine($"{Nombre} es gerente de la empresa y toma decisiones.");
        }

    }

    public class Desarrollador : Empleado
    {
        public Desarrollador(string nombre) : base(nombre)
        {

        }

        public void Programar()
        {
            Console.WriteLine($"{Nombre} es programador(a) y esta desarrollando una aplicacion.\n");
        }
    }

    public class Vehiculo
    {
        public void Avanzar()
        {
            Console.WriteLine("El vehiculo avanza.");
        }
    }

    public class Auto : Vehiculo
    {
        public void EncenderRadio()
        {
            Console.WriteLine("El radio funciona.");
        }
    }
    public class Motocicleta : Vehiculo
    {
        public void HacerCaballito()
        {
            Console.WriteLine("La motocicleta hace un caballito.");
        }
    }

    public class Cuenta
    {
        protected double Saldo;

        public Cuenta(double SaldoInicial)
        {
            Saldo = SaldoInicial;
        }

        public virtual void Depositar(double monto)
        {
            if (monto > 0)
            {
                Saldo += monto;
                Console.WriteLine($"Su depósito de Q{monto} fue realizado correctamente. \nSaldo actual: Q{Saldo}");
            }
            else
            {
                Console.WriteLine("El monto ingresado debe ser mayor a 0.");
            }
        }

        public virtual void CalcularInteres()
        {
            Console.WriteLine("Esta cuenta no genera intereses.");
        }
    }

    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(double SaldoInicial) : base(SaldoInicial)
        {
        }

        public override void CalcularInteres()
        {
            double interes = Saldo * 0.05;
            Saldo += interes;
            Console.WriteLine($"Intereses generados: Q{interes}. \nSaldo nuevo: Q{Saldo}");
        }
    }

    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(double SaldoInicial) : base(SaldoInicial)
        {
        }

        public override void CalcularInteres()
        {
            Console.WriteLine("Esta cuenta no genera intereses.");
        }
    }

}