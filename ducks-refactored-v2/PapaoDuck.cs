using System.Windows.Forms;
using Ducks.Behaviors;

namespace Ducks
{
    /// <summary>
    /// PapaoDuck: planeja sobre a água e grasna suave.
    /// </summary>
    public class PapaoDuck : Duck
    {
        public PapaoDuck()
            : base("Pato Papão", new GlideBehavior(), new QuackSoft())
        {
        }

        public override void Display()
        {
            MessageBox.Show("Exibindo Pato Papão na tela.");
        }
    }
}
