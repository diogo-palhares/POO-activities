using System;
using System.Reflection;
using Patos;

namespace POOActivities
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck myDuck = new RedHeadDuck("Bernardo", 21);
            Console.WriteLine("=== Informações do Pato 1 ===");
            myDuck.Display();
            myDuck.Swim();
            ((IQuackable)myDuck).Quack();
            ((IFlyable)myDuck).Fly();

            RedHeadDuck myDuck2 = new RedHeadDuck("Diogo", 22);
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

            RubberDuck myDuck4 = new RubberDuck("Ivo", 21);
            Console.WriteLine("=== Informações do Pato 4 ===");
            myDuck4.Display();
            myDuck4.Quack();
            myDuck4.Swim();

            Menu menu = new Menu();
            menu.Run();
        }
    }
}