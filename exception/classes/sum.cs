using System;

namespace Exep
{
    public static class Sum
    {
        public static void Run()
        {
            int sum = 0, count = 0;

            while (true)
            {
                Console.Write("Digite um número inteiro: ");
                try
                {
                    int value = int.Parse(Console.ReadLine());

                    if (sum + value > 100)
                        // lança a exceção que agora está em arquivo separado
                        throw new ExcecaoAcimaDeCem(sum, count);

                    sum += value;
                    count++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Digite apenas números inteiros.");
                }
                catch (ExcecaoAcimaDeCem ex)
                {
                    Console.WriteLine("\n=== Resultado Antes de Ultrapassar 100 ===");
                    Console.WriteLine($"Soma acumulada: {ex.Sum}");
                    Console.WriteLine($"Total de números somados: {ex.Count}");
                    double media = ex.Count > 0 ? (double)ex.Sum / ex.Count : 0;
                    Console.WriteLine($"Média: {media:F2}");
                    return;
                }
            }
        }
    }
}
