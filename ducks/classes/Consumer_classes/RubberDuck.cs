using System;

namespace Patos
{
    public class RubberDuck : Duck, IQuackable
    {
        public RubberDuck(string name, int age)
            : base(name, age)
        {
            Type = "Pato de Borracha";
        }

        public void Quack()
        {
            Console.WriteLine($"*{Name} faz um som de brinquedo*");
        }

        public override void Swim()
        {
            Console.WriteLine($"{Name} continue a nadar.");
        }
    }
}