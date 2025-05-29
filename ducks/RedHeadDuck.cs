using System;

namespace Patos
{
    public class RedHeadDuck : Duck, IFlyable, IQuackable
    {
        public RedHeadDuck(string name, int age) : base(name, age)
        {
            Type = "Pato da Cabeça Vermelha";
        }

        public override string Swim()
        {
            return $"{Name} está nadando bem";
        }

        public string Fly()
        {
            return $"{Name} está voando bem";
        }

        public string Quack()
        {
            return $"{Name} está quackando bem";
        }
    }
}
