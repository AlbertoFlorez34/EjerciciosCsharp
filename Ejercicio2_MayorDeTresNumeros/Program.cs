using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el segundo número: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el tercer número: ");
        int c = int.Parse(Console.ReadLine());

        int mayor = a;
        if (b > mayor) mayor = b;
        if (c > mayor) mayor = c;

        Console.WriteLine($"El número mayor es: {mayor}");
    }
}