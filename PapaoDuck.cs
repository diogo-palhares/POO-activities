using System;

namespace Patos
{
    public class PapaoDuck : Duck, IQuackable
    {
        public PapaoDuck(string name, int age) : base(name, age)
        {
            Type = "Pato Papão";
        }

        public override string Swim()
        {
            return $"{Name} nada sorrateiramente pelas sombras.";
        }

        public string Quack()
        {
            return $"{Name} solta um quack grave e assustador... \nHAHAHAHHAHAAHHAHAHAHA...";
        }

        public string Rimar()
        {
            return $"{Name} diz: 'Eu sou o Pato Papão, espalho o terror e confusão!'";
        }

        public string Zoar()
        {
            return $"{Name} grita: 'Pato que nada muito vira bolsa de madame!'";
        }

        public string Comer()
        {
            return $"{Name} devora uma janta de 2kg com pressa... \ne um programador de sobremesa!";
        }

        public string Autodestruir()
        {
            return $"{Name} ativa a autodestruição em 3... 2... 1... \n*BOOM* (Mas ele sempre volta)";
        }
    }
}
