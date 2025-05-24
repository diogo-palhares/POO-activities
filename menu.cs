using System.Collections.Generic;

namespace Patos
{
    public class Menu
    {
        private readonly List<Duck> _ducks;
        private Duck? escolhido { get; set; }

        public Menu()
        {
            _ducks = new List<Duck>{
                new MallardDuck("Ana Flavia", 29),
                new RubberDuck("Ivo", 21),
                new RedHeadDuck("Bernardo", 21),
                new Pokepato("Patochu", 15),
                new MathDuck("Patágoras", 345),
                new PapaoDuck("Pato Papão", 74)
            };
        }

        public List<Duck> GetDucks()
        {
            return _ducks;
        }

        public Duck GetDuck(int index)
        {
            return _ducks[index];
        }

        public void SetEscolhido(int index)
        {
            if (index >= 0 && index < _ducks.Count)
                escolhido = _ducks[index];
        }

        public Duck? GetEscolhido()
        {
            return escolhido;
        }
    }
}
