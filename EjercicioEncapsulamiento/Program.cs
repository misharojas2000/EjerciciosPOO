using System;
using Encapsulamiento;

Empleado e1 = new Empleado();
e1.Nombre = "Mishell";
e1.Salario = 5000.00;
Console.WriteLine($"Nombre: {e1.Nombre}, Salario: {e1.Salario} \n");

CuentaBancaria c1 = new CuentaBancaria(5000);
c1.Retirar(1500);
Console.WriteLine($"Su nuevo saldo es de {c1.MostrarSaldo()} \n");

Vehiculo arrancar = new Vehiculo();
arrancar.Encender("Encender");
arrancar.Encender("Apagar");
arrancar.Encender("Encender");
arrancar.Encender("Encender");
arrancar.Encender("Apagar");
arrancar.Encender("Apagar");