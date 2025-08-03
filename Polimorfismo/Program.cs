using Polimorfismo;

List<Notificacion> Notificaciones = new List<Notificacion>
    {
        new NotificacionEmail(),
        new NotificacionSMS(),
        new NotificacionPush()
    };

foreach (var notification in Notificaciones)
{
    notification.Enviar();
}