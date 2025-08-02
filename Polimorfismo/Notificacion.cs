using Polimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public  class Notificacion
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

    List<Notificacion> Notificaciones = new List<Notificacion>
    {
        new NotificacionEmail(),
        new NotificacionSMS(),
        new NotificacionPush()
    };
        foreach (var notification in Notificaciones){
        notification.Enviar();)
}

public class ComandoVoz
{
 public virtual void Ejecutar()
{
    Console.WriteLine("Ejecutando tarea.")
}   
public class EncenderLuces : ComandoVoz
{
    public override void Ejecutar()
    {
        Console.WriteLine("Encendiendo las luces del apartamento.");
    }
}
public class  ReproducirMusica : ComandoVoz
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

