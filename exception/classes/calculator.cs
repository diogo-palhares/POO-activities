using System;

namespace Exep
{
    public class Calculator
    {
        public static void Run()
        {
            double a = 0, b = 0;
            while (true)
            {
                try
                {
                    Console.Write("Digite o primeiro número: ");
                    a = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    b = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número.");
                }
            }

            Console.WriteLine("\nEscolha a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Módulo");
            Console.Write("Opção: ");
            string op = Console.ReadLine();

            try
            {
                double resultado = op switch
                {
                    "1" => a + b,
                    "2" => a - b,
                    "3" => a * b,
                    "4" => a / b,
                    "5" => a % b,
                    _   => throw new InvalidOperationException("Operação inválida.")
                };

                Console.WriteLine($"\nResultado: {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nErro: divisão por zero!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
            catch (Exception)
            {
                Console.WriteLine("\nOcorreu um erro inesperado.");
            }
        }
    }
}
