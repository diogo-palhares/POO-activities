using System;
using Patos; 

namespace POOActivities
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck myDuck2 = new RedHeadDuck("Diogo", 21, "GIGANTE");
            Console.WriteLine("=== Informações do Pato ===");
            myDuck2.Display();
            myDuck2.Swim();
            ((IQuackable)myDuck2).Quack();
            ((IFlyable)myDuck2).Fly();
        }
    }
}