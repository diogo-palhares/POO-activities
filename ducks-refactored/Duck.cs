using Ducks.Behaviors;

namespace Ducks
{
    /// <summary>
    /// Classe abstrata base para todos os patos.
    /// Seus comportamentos de voo e grasnar são definidos por Strategy.
    /// </summary>
    public abstract class Duck
    {
        // Atributos que apontam para as estratégias de voo e de grasnar
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        // Nome do pato (útil para exibição ou identificação)
        public string Name { get; protected set; }

        /// <summary>
        /// Construtor recebe as implementações de voo e de grasnar.
        /// </summary>
        protected Duck(string name, IFlyBehavior flyB, IQuackBehavior quackB)
        {
            Name = name;
            flyBehavior = flyB;
            quackBehavior = quackB;
        }

        /// <summary>
        /// Executa o comportamento de voo associado (delegado a IFlyBehavior).
        /// </summary>
        public void PerformFly()
        {
            flyBehavior?.Fly();
        }

        /// <summary>
        /// Executa o comportamento de grasnar associado (delegado a IQuackBehavior).
        /// </summary>
        public void PerformQuack()
        {
            quackBehavior?.Quack();
        }

        /// <summary>
        /// Permite alterar em tempo de execução o comportamento de voo.
        /// </summary>
        public void SetFlyBehavior(IFlyBehavior newFlyBehavior)
        {
            flyBehavior = newFlyBehavior;
        }

        /// <summary>
        /// Permite alterar em tempo de execução o comportamento de grasnar.
        /// </summary>
        public void SetQuackBehavior(IQuackBehavior newQuackBehavior)
        {
            quackBehavior = newQuackBehavior;
        }

        /// <summary>
        /// Cada pato concreto deve implementar seu próprio Display() para a UI.
        /// </summary>
        public abstract void Display();
    }
}
