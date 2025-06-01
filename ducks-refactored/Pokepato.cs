using System.Windows.Forms;
using Ducks.Behaviors;

namespace Ducks
{
    /// <summary>
    /// Pokepato: voa devagar e grasna alto.
    /// </summary>
    public class Pokepato : Duck
    {
        public Pokepato()
            : base("PokePato", new FlySlow(), new QuackLoud())
        {
        }

        public override void Display()
        {
            MessageBox.Show("Exibindo PokePato na tela.");
        }
    }
}
