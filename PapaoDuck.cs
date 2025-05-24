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
            return $"{Name} nada sorrateiramente\n pelas sombras.";
        }

        public string Quack()
        {
            return $"{Name} solta um quack\n grave e assustador... HAHAHAHHAHAAHHAHAHAHA...";
        }

        public string Rimar()
        {
            return $"{Name} diz: 'Eu sou o Pato Papão,\n espalho o terror e confusão!'";
        }

        public string Zoar()
        {
            return $"{Name} grita: 'Pato que nada muito\n vira bolsa de madame!'";
        }

        public string Comer()
        {
            return $"{Name} devora uma janta de 2kg \ncom pressa... e um programador de sobremesa!";
        }

        public string Autodestruir()
        {
            return $"{Name} ativa a autodestruição \nem 3... 2... 1... *BOOM* (Mas ele sempre volta)";
        }
    }
}
