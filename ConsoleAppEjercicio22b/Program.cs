using System;

namespace ConsoleAppEjercicio22b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Comparar 2 número";
            Console.Write("Ingrese un número:");
            var numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número:");
            var numero2 = int.Parse(Console.ReadLine());

            if (numero1>numero2)
            {
                Console.WriteLine($"{numero1} es mayor que {numero2}");
            }else if (numero1<numero2)
            {
                Console.WriteLine($"{numero2} es mayor que {numero1}");
            }
            else
            {
                Console.WriteLine($"Ambos números son iguales");
            }

            Console.ReadLine();

        }
    }
}
