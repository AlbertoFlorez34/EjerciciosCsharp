using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número máximo: ");
        int max = int.Parse(Console.ReadLine());

        Console.WriteLine("Números pares:");
        for (int i = 2; i <= max; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}