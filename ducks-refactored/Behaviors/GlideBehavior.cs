using System.Windows.Forms;

namespace Ducks.Behaviors
{
    /// <summary>
    /// Planagem: exibe “O pato está planando suavemente sobre as águas.”
    /// </summary>
    public class GlideBehavior : IFlyBehavior
    {
        public void Fly()
        {
            MessageBox.Show("O pato está planando suavemente sobre as águas.");
        }
    }
}
