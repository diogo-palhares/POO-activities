using System.Windows.Forms;

namespace Ducks.Behaviors
{
    /// <summary>
    /// Voo lento: exibe “O pato voa devagar, aproveitando a brisa.”
    /// </summary>
    public class FlySlow : IFlyBehavior
    {
        public void Fly()
        {
            MessageBox.Show("O pato voa devagar, aproveitando a brisa.");
        }
    }
}
