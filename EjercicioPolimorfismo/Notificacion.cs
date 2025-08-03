using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Notificacion
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Enviando Notificacion.");
        }
    }
    public class NotificacionEmail : Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando correo electronico.");
        }
    }
    public class NotificacionSMS : Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando SMS.");
        }
    }

    public class NotificacionPush : Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando notificacion push.");
        }
    }

    public class ComandoVoz
    {
        public virtual void Ejecutar()
        {
            Console.WriteLine("Ejecutando tarea.");
        }
        public class EncenderLuces : ComandoVoz
        {
            public override void Ejecutar()
            {
                Console.WriteLine("Encendiendo las luces del apartamento.");
            }
        }
        public class ReproducirMusica : ComandoVoz
        {
            public override void Ejecutar()
            {
                Console.WriteLine("Reproduciendo musica en Spotify.");
            }

        }

        public class MostrarClima : ComandoVoz
        {
            public override void Ejecutar()
            {
                Console.WriteLine("Mostrando el clima del dia de hoy.");
            }

        }
    }

    public class Pago
    {
        public virtual void ProcesarPago()
        {
            Console.WriteLine("Procesando pago.");
        }
    }

    public class PagoConTarjeta : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Procesando pago con tarjeta.");
        }
    }

    public class PagoConEfectivo : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Recibiendo efectivo.");
        }
    }

    public class PagoConTransferencia : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Iniciando transferencia bancaria.");
        }
    }

}