using System;

namespace Patos
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public MallardDuck(string name, int age) : base(name, age)
        {
            Type = "Pato Real";
        }

        public override string Swim()
        {
            return $"{Name} está nadando... Nadaaar..";
        }

        public string Fly()
        {
            return $"{Name} está voando.. Voaaaar..";
        }

        public string Quack()
        {
            return $"{Name} está quackando.. Quááááa...";
        }
    }
}
