using System.Windows.Forms;

namespace Ducks.Behaviors
{
    /// <summary>
    /// Grasnado alto: exibe “QUAACK!!”
    /// </summary>
    public class QuackLoud : IQuackBehavior
    {
        public void Quack()
        {
            MessageBox.Show("QUAACK!!");
        }
    }
}
