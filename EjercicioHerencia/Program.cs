using System;
using EjercicioHerencia;

Empleado e1 = new Empleado("Pablo");
Gerente g1 = new Gerente("Luis");
Desarrollador d1 = new Desarrollador("Fernanda");

e1.Trabajar();
g1.TomarDecision();
d1.Programar();

Vehiculo v1 = new Vehiculo();
Auto a1 = new Auto();
Motocicleta m1 = new Motocicleta();
v1.Avanzar();
a1.Avanzar();
a1.EncenderRadio();
m1.Avanzar();
m1.HacerCaballito();

CuentaAhorro ahorro = new CuentaAhorro(1000);
ahorro.Depositar(500);
ahorro.CalcularInteres();

CuentaCorriente corriente = new CuentaCorriente(2500);
corriente.Depositar(500);
corriente.CalcularInteres();
