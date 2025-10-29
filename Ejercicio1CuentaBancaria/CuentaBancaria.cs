using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1CuentaBancaria
{
    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public CuentaBancaria(string titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal monto)
        {
            if (monto > 0) Saldo += monto;
        }

        public void Retirar(decimal monto)
        {
            if (monto > Saldo)
                Console.WriteLine("No hay suficiente saldo.");
            else
                Saldo -= monto;
        }
    }
}
