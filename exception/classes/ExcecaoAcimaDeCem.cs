using System;

namespace Exep
{
    public class ExcecaoAcimaDeCem : Exception
    {
        public int Sum { get; }
        public int Count { get; }

        public ExcecaoAcimaDeCem(int sum, int count)
            : base("Soma ultrapassou 100.")
        {
            Sum   = sum;
            Count = count;
        }
    }
}
