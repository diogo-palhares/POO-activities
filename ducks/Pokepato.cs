using System;

namespace Patos
{
    public class Pokepato : Duck, IFlyable, IQuackable
    {
        public Pokepato(string name, int age) : base(name, age)
        {
            Type = "Pokepato";
        }

        public string Levitar()
        {
            return $"{Name} está levitando..";
        }

        public string Raiox()
        {
            return $"{Name} está soltando raio";
        }

        public string Speed()
        {
            return $"{Name} está usando correndo..";
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

        public string Chacoalhar()
        {
            return $"{Name} está chacoalhando.. Chacoalhar..";
        }
    }
}
