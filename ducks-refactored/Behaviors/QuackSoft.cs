using System.Windows.Forms;

namespace Ducks.Behaviors
{
    /// <summary>
    /// Grasnado suave: exibe “quack…”
    /// </summary>
    public class QuackSoft : IQuackBehavior
    {
        public void Quack()
        {
            MessageBox.Show("quack…");
        }
    }
}
