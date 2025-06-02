using Ducks.Behaviors;

namespace Ducks
{
    /// <summary>
    /// Classe abstrata base para todos os patos.
    /// Seus comportamentos de voo e grasnar são definidos por Strategy.
    /// </summary>
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public string Name { get; protected set; }

        protected Duck(string name, IFlyBehavior flyB, IQuackBehavior quackB)
        {
            Name = name;
            flyBehavior = flyB;
            quackBehavior = quackB;
        }

        public void PerformFly()
        {
            flyBehavior?.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior?.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior newFlyBehavior)
        {
            flyBehavior = newFlyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior newQuackBehavior)
        {
            quackBehavior = newQuackBehavior;
        }

        public abstract void Display();
    }
}
