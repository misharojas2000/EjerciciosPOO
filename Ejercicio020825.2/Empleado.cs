using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia._2
{
    internal class Empleado
    {
        public string Nombre { get; set; };
        public double Salario { get; set; };

    }

    internal class Gerente : Empleado {
        public void TomarDecision();
        Console.WriteLine("Tomar una desicion")
     }

    internal class Desarrollador : Empleado
    {
        public void Programar();
        Console.WriteLine("Programar una aplicacion");
    }


    public  class Vehiculo { }
    {
        public Avanzar()
}

}