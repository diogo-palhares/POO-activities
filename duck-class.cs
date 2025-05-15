using System;

namespace Patos {

    public abstract class Duck {

        public string Name {get; set;}
        public int Age {get; set;}
        public string? Type {get; protected set;}

        public Duck(string name, int age){
            Name = name;
            Age = age;
        }

        public abstract string Swim();

        public void Display(){
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Idade: {Age} anos");
            Console.WriteLine($"Tipo: {Type}");
        }
    }
}