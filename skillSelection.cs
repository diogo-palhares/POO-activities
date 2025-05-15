using System;
using System.Reflection;

namespace Patos{
    public class SkillMenu{
        private Duck Escolhido {get;set;}
        public SkillMenu(Duck escolhido){
            Escolhido = escolhido;
        }

        public void Run(){
            while(true){
                Console.Clear();
                Console.WriteLine("Escolha qual habilidade usar");
                Escolhido.Display();
                Console.WriteLine("Habilidades:");
                Type tipo = Escolhido.GetType();
                MethodInfo[] metodos = tipo.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                int i=1;
                Console.WriteLine($"{0}- Sair");
                foreach (var m in metodos)
                {
                    Console.WriteLine($"{i}- {m.Name}");
                    i++;
                }
                string input = Console.ReadLine();
                if(int.TryParse(input, out int skill)){
                    if(skill==0)
                        break;
                    if(skill>metodos.Length || skill<0){
                        Console.WriteLine("Opção invalida");
                        Console.WriteLine("Precione qualquer tecla para continuar");
                        Console.ReadKey();
                    }
                    else{
                        metodos[skill-1].Invoke(Escolhido,[]);
                        Console.ReadKey();
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