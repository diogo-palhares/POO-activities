using System;

namespace Exep
{
    public class PrimeChecker
    {
        public static void Run()
        {
            int number;
            while (true)
            {
                Console.Write("Digite um número inteiro: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
            }

            if (IsPrime(number))
                Console.WriteLine($"\n{number} é primo.");
            else
                Console.WriteLine($"\n{number} não é primo.");
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
