using System;

namespace Patos {
    
    public abstract class Duck {

        private string Name {get;set;}
        private int Age {get;set;}
    
        public Duck(string name; int age){
            Name = name;
            Age = age;
        }

        public abstract void Swin();

        public abstract void Display();
    }
}