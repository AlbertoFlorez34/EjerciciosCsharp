using System;
using Ejercicio1CuentaBancaria;

class Program
{
    static void Main()
    {
        CuentaBancaria miCuenta = new CuentaBancaria("Alberto", 1000);
        miCuenta.Depositar(500);
        miCuenta.Retirar(200);
        Console.WriteLine($"Saldo final: {miCuenta.Saldo}");
    }
}
