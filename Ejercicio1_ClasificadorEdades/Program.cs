using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 13)
            Console.WriteLine("Eres un niño.");
        else if (edad < 18)
            Console.WriteLine("Eres un adolescente.");
        else if (edad < 65)
            Console.WriteLine("Eres un adulto.");
        else
            Console.WriteLine("Eres un adulto mayor.");
    }
}
