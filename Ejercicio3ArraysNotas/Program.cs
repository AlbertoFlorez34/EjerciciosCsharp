
//Ejercicio: Calcular el promedio de notas de un estudiante
//Usar un array para almacenar las notas y calcular el promedio.

using System;

class Program
{
    static void Main()
    {
        // Crear un array de 5 notas
        double[] notas = new double[5];

        // Pedir las notas al usuario
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Ingresa la nota #{i + 1}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calcular el promedio
        double suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

        double promedio = suma / notas.Length;

        // Mostrar el resultado
        Console.WriteLine($"\nEl promedio de las notas es: {promedio:F2}");

        // Mostrar si aprobó o no
        if (promedio >= 3.0)
            Console.WriteLine("El estudiante aprobó 🎉");
        else
            Console.WriteLine("El estudiante reprobó 😔");
    }
}