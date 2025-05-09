using System;

namespace Patos {
    public class Pokepato : Duck, IFlyable, IQuackable
    {
        public Pokepato(string name, int age) : base(name, age)
        {
            Type = "Pokepato";

        }
        public void Levitar()
        {
            Console.WriteLine($"{Name} está levitando..");
        }

        public void Raiox()
        {
            Console.WriteLine($"{Name} está soltando raio");
        }
        public void Speed()
        {
            Console.WriteLine($"{Name} está usando correndo..");
        }
        public override void Swim()
        {
            Console.WriteLine($"{Name} está nadando... Nadaaar..");
        }
        public void Fly()
        {
            Console.WriteLine($"{Name} está voando.. Voaaaar..");
        }

        public void Quack()
        {
            Console.WriteLine($"{Name} está quackando.. Quááááa...");
        }
        public void Chacoalhar()
        {
            Console.WriteLine($"{Name} está chacoalhando.. Chacoalhar..");
        }

    } 

}