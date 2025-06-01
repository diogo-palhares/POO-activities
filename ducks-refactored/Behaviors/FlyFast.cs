using System.Windows.Forms;

namespace Ducks.Behaviors
{
    /// <summary>
    /// Voo rápido: exibe uma mensagem “O pato voa rápido pelo lago!”
    /// </summary>
    public class FlyFast : IFlyBehavior
    {
        public void Fly()
        {
            MessageBox.Show("O pato voa rápido pelo lago!");
        }
    }
}
