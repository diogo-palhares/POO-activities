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
        public void Soma(int a, int b)
        {
            Console.WriteLine($"A Soma de {a} + {b} é: {a + b}");
        }
        public void Subtracao(int a, int b)
        {
            Console.WriteLine($"A Subtracao de {a} - {b} é: {a - b}");
        }
        public void Multiplicacao(int a, int b)
        {
            Console.WriteLine($"A Multiplicacao de {a} * {b} é: {a * b}");
        }
        public void Divisao(int a, int b)
        {
            Console.WriteLine($"A Divisao de {a} / {b} é: {a / b}");
        }


    }


}