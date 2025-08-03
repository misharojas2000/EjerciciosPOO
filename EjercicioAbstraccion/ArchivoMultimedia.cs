using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public abstract class ArchivoMultimedia
    {
        public abstract void Reproducir();
    }

    public class Video : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo Video");
        }
    }

    public class Cancion : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo Cancion");
        }
    }

    public class AudioLibro : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo AudioLibro");
        }
    }

    public interface IValidador
    {
        void EsValido(string dato);
    }

    public class ValidadorEmail : IValidador
    {
        public void EsValido(String dato)
        {
            if (!dato.Contains("@")){
                Console.WriteLine("El email no es valido.");
            }
            else
            {
                Console.WriteLine("Email valido.");
            }
        }
    }

        public class ValidadorTelefono : IValidador
        {
            public void EsValido(String dato)
            {
                if (dato.Length != 8 || !dato.All(char.IsDigit))
                {
                    Console.WriteLine("El numero de telefono no es valido.");
                } else
                {
                Console.WriteLine("Numero de telefono valido");
                }
            }
        }

    public class  ValidadorDPI : IValidador 
    {
        public void EsValido(String dato)
        {
            if (dato.Length != 13 || !dato.All(char.IsDigit))
            {
                Console.WriteLine("El numero de DPI no es valido.");
            }
            else
            {
                Console.WriteLine("Numero de DPI valido");
            }
        }
    }

    public abstract class DispositivoSalida
    {
        protected string Mensaje;

        public DispositivoSalida(string mensaje)
        {
            Mensaje = mensaje;
        }

        public abstract void Mostrar();
    }

    public class Pantalla : DispositivoSalida
    {
        public Pantalla(string mensaje) : base(mensaje) { }

        public override void Mostrar()
        {
            Console.WriteLine(Mensaje);
        }
    }

    public class Proyector : DispositivoSalida
    {
        public Proyector(string mensaje) : base(mensaje) { }

        public override void Mostrar()
        {
            Console.WriteLine($"Lanzando proyección: {Mensaje}");
        }
    }

    public class Impresora : DispositivoSalida
    {
        public Impresora(string mensaje) : base(mensaje) { }

        public override void Mostrar()
        {
            Console.WriteLine($"Imprimiendo mensaje: {Mensaje}");
        }
    }

}