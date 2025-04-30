using System;

namespace Patos
{
    public class RedHeadDuck : Duck, IFlyable, IQuackable
    {

        public RedHeadDuck(string name, int age)
            : base(name, age)
        {
            Type = "Cabeça Vermelha";
        }

        public override void Swim()
        {
            Console.WriteLine($"{Name} está nadando bem");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} está voando bem");
        }

        public void Quack()
        {
            Console.WriteLine($"{Name} está quackando bem");
        }

    }
}