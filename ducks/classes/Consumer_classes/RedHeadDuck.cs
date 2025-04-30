using System;
using Patos;

namespace Patos
{
    public class RedHeadDuck : Duck, IFlyable, IQuackable
    {
        public string CabecaVermelha { get; protected set; }

        public RedHeadDuck(string name, int age, string cabecaVermelha)
            : base(name, age)
        {
            CabecaVermelha = cabecaVermelha;
        }

        public override void Swim()
        {
            Console.WriteLine($"{Name} está nadando bem");
        }

        public override void Display()
        {
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Idade: {Age} anos");
            Console.WriteLine($"Cabeça vermelha: {CabecaVermelha}");
        }
        public void Fly()
        {
            Console.WriteLine($"{Name} voando bem");
        }

        public void Quack()
        {
            Console.WriteLine($"{Name} quackando bem");
        }

    }
}