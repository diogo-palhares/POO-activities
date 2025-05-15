using System;

namespace Patos
{
    public class MathDuck : Duck, IQuackable
    {
        public MathDuck(string name, int age) : base(name, age)
        {
            Type = "Pato Matematico";
        }

        public override string Swim()
        {
            return $"{Name} está nadando, com medo....";
        }

        public string Quack()
        {
            return $"{Name} está barulhando";
        }

        public string Soma()
        {
            return "Insira o primeiro numero";
        }

        public string Subtracao()
        {
            return "Insira o primeiro numero";
        }

        public string Multiplicacao()
        {
            return "Insira o primeiro numero";
        }

        public string Divisao()
        {
            return "Insira o primeiro numero";
        }
    }
}
