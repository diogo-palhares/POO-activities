using System;

namespace Exep
{
    public class ArrayFiller
    {
        public static void Run()
        {
            int[] vetor = new int[10];
            int preenchidos = 0;

            while (preenchidos < vetor.Length)
            {
                try
                {
                    Console.Write("Informe a posição (0 a 9): ");
                    int pos = int.Parse(Console.ReadLine());

                    Console.Write("Informe o valor inteiro: ");
                    int valor = int.Parse(Console.ReadLine());

                    vetor[pos] = valor;
                    preenchidos++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Digite apenas números inteiros.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Posição inválida. Informe um índice entre 0 e 9.");
                }
            }

            Console.WriteLine("\nConteúdo final do vetor:");
            for (int i = 0; i < vetor.Length; i++)
                Console.WriteLine($"[{i}] = {vetor[i]}");
        }
    }
}
