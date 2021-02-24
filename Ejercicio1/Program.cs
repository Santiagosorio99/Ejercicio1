using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double promedio = 0;
            Console.WriteLine("Digite las notas");
            Console.Write("Digite la nota 1:");
            nota1 = Double.Parse(Console.ReadLine());
            Console.Write("Digite la nota 2:");
            nota2 = Double.Parse(Console.ReadLine());
            Console.Write("Digite la nota 3:");
            nota3 = Double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("El promedio es:");
            Console.WriteLine(promedio);
            if (promedio > 2.95)
            {
                Console.WriteLine("El estudiante aprobó");
            }
            else
            {
                Console.WriteLine("El estudiante reprobó");
            }
            Console.ReadLine();
        }
    }
}
