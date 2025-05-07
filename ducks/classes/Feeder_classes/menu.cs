using System;
using System.Reflection;

namespace Patos
{
    public class Menu
    {
        private readonly List<Duck> _ducks;
        private Duck? escolhido{get;set;}

        public Menu()
        {
            _ducks = new List<Duck>{
                new MallardDuck("Ana Flavia", 29),
                new RubberDuck("Ivo", 21),
                new RedHeadDuck("Bernardo", 21)
            };
        }

        public void Run()
        {
            int i = 0;
            while (i!=-1)
            {
                i=i%_ducks.Count;
                Console.Clear();
                Console.WriteLine($"Pato {i + 1}");
                _ducks[i].Display();
                Console.WriteLine($"Habilidades:");

                Type tipo = _ducks[i].GetType();
                MethodInfo[] metodos = tipo.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var m in metodos)
                {
                    Console.WriteLine($"-{m.Name}");
                }

                Console.WriteLine("Anterior(1) Proximo(2) Escolher (3) Sair(4)");
                string input = Console.ReadLine();
                if(int.TryParse(input, out int opcao)){
                    switch(opcao){
                        case 1:
                            i--;
                            break;
                        case 2:
                            i++;
                            break;
                        case 3:
                            escolhido = _ducks[i];
                            break;
                        case 4:
                            i=-1;
                            break;
                        default:
                            Console.WriteLine("Opção invalida");
                            Console.WriteLine("Precione qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                    }
                }
                else{
                    Console.WriteLine("Insira um caractere valido");
                    Console.WriteLine("Precione qualquer tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
    }
}