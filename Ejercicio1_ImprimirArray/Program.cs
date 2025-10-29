using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Elementos del array:");
        foreach (var num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}