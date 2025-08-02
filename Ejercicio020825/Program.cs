using System;
using Ejercicio020825;

Empleado e1 = new Empleado();
e1.Nombre = "Mishell";
e1.Salario = 5000.00;
Console.WriteLine($"Nombre: {e1.Nombre}, Salario: {e1.Salario}");

CuentaBancaria c1 = new CuentaBancaria(5000);
c1.Retirar(500);
Console.WriteLine(c1.MostrarSaldo());