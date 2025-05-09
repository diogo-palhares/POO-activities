using System;

namespace Patos
{
    public class MathDuck : Duck, IQuackable
    {
        public MathDuck(string name, int age) : base(name, age)
        {
            Type = "Pato Matematico";
        }

        public override void Swim()
        {
            Console.WriteLine($"{Name} está nadando, com medo....");
        }

        public void Quack()
        {
            Console.WriteLine($"{Name} está barulhando");
        }
        public void Soma()
        {
            Console.WriteLine("Insira o primeiro numero");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"A Soma de {a} + {b} é: {a + b}");
        }
        public void Subtracao()
        {
            Console.WriteLine("Insira o primeiro numero");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"A Subtracao de {a} - {b} é: {a - b}");
        }
        public void Multiplicacao()
        {
            Console.WriteLine("Insira o primeiro numero");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"A Multiplicacao de {a} * {b} é: {a * b}");
        }
        public void Divisao()
        {
            Console.WriteLine("Insira o primeiro numero");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            double b = double.Parse(Console.ReadLine());
            if (a == 0 && b == 0)
                Console.WriteLine("Nao da pra dividir 0 por 0");
            else
                Console.WriteLine($"A Divisao de {a} / {b} é: {a / b}");
        }
    }
}