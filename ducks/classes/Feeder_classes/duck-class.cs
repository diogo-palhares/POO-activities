using System;

namespace Patos {

    public abstract class Duck {

        protected string Name {get;set;}
        protected int Age {get;set;}
        protected string? Type {get;set;}

        public Duck(string name, int age){
            Name = name;
            Age = age;
        }

        public abstract void Swim();

        public void Display(){
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Idade: {Age} anos");
            Console.WriteLine($"Tipo: {Type}");
        }
    }
}