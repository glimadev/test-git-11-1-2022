using System;

namespace CalculoDeMediaApp
{
    class Program
    {
        /// <summary>
        /// Calcular a media entre 2 notas
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string continuar = "S";

            do
            {
                Console.WriteLine("Digitar nota1:");

                double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digitar nota2:");

                double nota2 = Convert.ToDouble(Console.ReadLine());

                double resultado = (nota1 + nota2) / 2;

                if (resultado < 7.0)
                {
                    Console.WriteLine("Você é um bosta");
                }
                else
                {
                    Console.WriteLine("Tá voando");
                }

                Console.WriteLine("Média => " + resultado);

                Console.WriteLine("Média Arredondada => " + Math.Round(resultado, 1, MidpointRounding.AwayFromZero));

                Console.WriteLine("Quer continuar? (S/N)");

                continuar = Console.ReadLine();

            } while (continuar == "S");

            Console.ReadKey();
        }
    }
}
