using EjercicioAbstraccion;
using System;
using static EjercicioAbstraccion.Pantalla;

List<ArchivoMultimedia> archivos = new List<ArchivoMultimedia>
{
new Video(),
new Cancion(),
new AudioLibro()

};

foreach (var files in archivos)
{
    files.Reproducir();
}

ValidadorEmail e1 = new ValidadorEmail();
ValidadorTelefono t1 = new ValidadorTelefono();
ValidadorDPI DPI1 = new ValidadorDPI();

ValidadorEmail e2 = new ValidadorEmail();
ValidadorTelefono t2 = new ValidadorTelefono();
ValidadorDPI DPI2 = new ValidadorDPI();

e1.EsValido("fmmonzonr@alumno.uspg.edu.gt");
t1.EsValido("54591634");
DPI1.EsValido("3018495620101");
e2.EsValido("misharojasgmail.com");
t2.EsValido("123456");
DPI2.EsValido("30184956201");

List<DispositivoSalida> dispositivos = new List<DispositivoSalida>
{
new Pantalla("Bienvenidos a la clase de programación."),
new Proyector("Hello World."),
new Impresora("Pilares POO")
};

foreach (var dispositivo in dispositivos)
{
    dispositivo.Mostrar();
}
