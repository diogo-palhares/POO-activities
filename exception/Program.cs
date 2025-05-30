using System;

namespace Exep
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Qual tarefa você quer executar?");
                Console.WriteLine("1 - Verificar número primo");
                Console.WriteLine("2 - Calculadora básica");
                Console.WriteLine("3 - Preencher vetor");
                Console.WriteLine("4 - Somar até exceder 100");
                Console.WriteLine("0 - Sair");
                var escolha = Console.ReadLine();

                Console.Clear();
                switch (escolha)
                {
                    case "1":
                        PrimeChecker.Run();
                        break;
                    case "2":
                        Calculator.Run();
                        break;
                    case "3":
                        ArrayFiller.Run();
                        break;
                    case "4":
                        Sum.Run();
                        break;
                    case "0":
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
}
