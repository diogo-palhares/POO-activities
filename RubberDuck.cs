using System;

namespace Patos
{
    public class RubberDuck : Duck, IQuackable
    {
        public RubberDuck(string name, int age) : base(name, age)
        {
            Type = "Pato de Borracha";
        }

        public string Quack()
        {
            return $"*{Name} faz um som de brinquedo*";
        }

        public override string Swim()
        {
            return $"{Name} continue a nadar.";
        }
    }
}
