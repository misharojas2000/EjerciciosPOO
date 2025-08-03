using EjercicioPolimorfismo;

List<Notificacion> Notificaciones = new List<Notificacion>
    {
        new Notificacion(),
        new NotificacionEmail(),
        new NotificacionSMS(),
        new NotificacionPush()
    };

foreach (var notification in Notificaciones)
{
    notification.Enviar();
}

List<ComandoVoz> Comandos = new List<ComandoVoz>
{
    new ComandoVoz(),
    new ComandoVoz.EncenderLuces(),
    new ComandoVoz.ReproducirMusica(),
    new ComandoVoz.MostrarClima()
};

foreach (var command in Comandos)
{
    command.Ejecutar();
}

List<Pago> Pagos = new List<Pago>
{
    new Pago(),
    new PagoConTarjeta(),
    new PagoConEfectivo(),
    new PagoConTransferencia()
};

foreach (var Payment in Pagos)
{
    Payment.ProcesarPago();
}