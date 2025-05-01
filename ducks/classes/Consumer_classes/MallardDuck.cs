using System;

namespace Patos {
    public class MallardDuck : Duck, IFlyable, IQuackable {
        public MallardDuck(string name, int age) : base(name, age) {
            Type = "Pato Real";
        }

        public override void Swim() {
            Console.WriteLine($"{Name} está nadando... Nadaaar..");
        }
  public void Fly() {
            Console.WriteLine($"{Name} está voando.. Voaaaar..");
        }

  public void Quack() {
            Console.WriteLine($"{Name} Quááááa...");
        }

    }

    
}