using System;

namespace Patos
{
    public class PatoPapao : Duck, IQuackable
    {
        public PatoPapao(string name, int age) : base(name, age)
        {
            Type = "Pato Papão";
        }

        public override void Swim()
        {
            Console.WriteLine($"{Name} nada sorrateiramente pelas sombras...");
        }

        public void Quack()
        {
            Console.WriteLine($"{Name} solta um quack grave e assustador... Quááááá...");
        }

        public void Rimar()
        {
            Console.WriteLine($"{Name} diz: 'Eu sou o Pato Papão, espalho o terror e confusão!'");
        }

        public void Zoar()
        {
            Console.WriteLine($"{Name} grita: 'Você nada ou boia? Porque eu voo até a sua bolha!'");
        }

        public void Comer()
        {
            Console.WriteLine($"{Name} devora um pão com pressa... e um programador de sobremesa!");
        }

        public void Autodestruir()
        {
            Console.WriteLine($"{Name} ativa a autodestruição em 3... 2... 1... *BOOM* (Mas ele sempre volta)");
        }
    }
}
