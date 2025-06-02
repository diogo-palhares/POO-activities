using System.Windows.Forms;
using Ducks.Behaviors;

namespace Ducks
{
    /// <summary>
    /// MallardDuck: voa rápido e grasna alto.
    /// </summary>
    public class MallardDuck : Duck
    {
        public MallardDuck()
            : base("Mallard Duck", new FlyFast(), new QuackLoud())
        {
        }

        public override void Display()
        {
            MessageBox.Show("Exibindo Mallard Duck na tela.");
        }
    }
}
