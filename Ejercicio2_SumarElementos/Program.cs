using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int suma = 0;
        foreach (var num in numeros)
        {
            suma += num;
        }
        Console.WriteLine($"La suma de los elementos es: {suma}");
    }
}