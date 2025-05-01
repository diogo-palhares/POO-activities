using System;
using Patos; 

namespace POOActivities
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck myDuck = new RedHeadDuck("Diogo", 21);
            Console.WriteLine("=== Informações do Pato 1 ===");
            myDuck.Display();
            myDuck.Swim();
            ((IQuackable)myDuck).Quack();
            ((IFlyable)myDuck).Fly();

            RedHeadDuck myDuck2 = new RedHeadDuck("Bernardo", 22);
            Console.WriteLine("=== Informações do Pato 2 ===");
            myDuck2.Display();
            myDuck2.Swim();
            myDuck2.Quack();
            myDuck2.Fly();

            MallardDuck myDuck3 = new MallardDuck("Ana Flavia", 29);
            Console.WriteLine("=== Informações do Pato 3 ===");
            myDuck3.Display();
            myDuck3.Swim();
            myDuck3.Quack();
            myDuck3.Fly();


        }
    }
}