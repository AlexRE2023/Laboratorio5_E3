using System;

namespace PromNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de notas: ");
            int cantdNts = int.Parse(Console.ReadLine());

            int SumaNts = 0;

            for (int i = 1; i <= cantdNts; i++)
            {
                Console.Write($"Ingrese la nota {i}: ");
                int Nota = int.Parse(Console.ReadLine());
                SumaNts += Nota;
            }

            int Promedio = SumaNts / cantdNts;

            Console.WriteLine($"El promedio es {Promedio}");
        }
    }
}
