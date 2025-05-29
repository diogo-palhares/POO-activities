# Duck Choose
`CURSO: Sistemas de Informação`

`DISCIPLINA: Programação Orientada por Objetos`

`SEMESTRE: 3º`


# Arquitetura do Projeto

Este projeto foi desenvolvido como atividade de aprendizagem de Programação Orientada a Objetos (POO). O desenvolvimento começou com uma aplicação de console, onde os conceitos de herança, polimorfismo, interfaces e encapsulamento foram aplicados. Posteriormente, evoluímos o projeto para uma aplicação com interface gráfica usando Windows Forms, tornando a interação mais intuitiva e amigável.

Abstração:
O conceito de pato foi abstraído na classe base Duck, que define os comportamentos gerais de qualquer pato, como Display(), Swim() e métodos para voar e grasnar.

Encapsulamento:
Os comportamentos de voar e grasnar são tratados separadamente através das interfaces IFlyable e IQuackable. Isso permite alterar os comportamentos sem modificar diretamente as classes dos patos.

Herança:
Diversas classes concretas estendem a classe base Duck, como MallardDuck, RedHeadDuck, RubberDuck, PapaoDuck, MathDuck e Pokepato. Cada uma sobrescreve o método Display() para apresentar sua aparência ou características específicas.

Polimorfismo:
Através das interfaces e da herança, é possível tratar todos os objetos do tipo Duck de maneira uniforme, chamando métodos como Fly() ou Quack() independentemente do tipo de pato.
Estrutura das Classes
Classe Base:

Duck: Classe abstrata que define a estrutura comum para todos os patos, com métodos como Display(), Swim(), além de propriedades para os comportamentos de voar e grasnar (IFlyable e IQuackable).

Interfaces de Comportamento:

IFlyable: Define o método Fly().

IQuackable: Define o método Quack().

Implementações Concretas de Patos:

MallardDuck: Pato selvagem padrão.

RedHeadDuck: Pato de cabeça vermelha.

RubberDuck: Pato de borracha que não voa, mas faz um som característico.

PapaoDuck: Tem comportamento personalizado.

MathDuck: Um pato matemático (com comportamento específico no contexto da aplicação).

Pokepato: Um pato inspirado no universo Pokémon.

GUI:

FormTela: Janela principal que permite ao usuário selecionar os diferentes tipos de pato e executar seus comportamentos (voar, nadar e grasnar) de forma visual.

Menus de Console (da versão anterior):

menu.cs e skillSelection.cs: Implementavam a interação textual antes da interface gráfica.


# Integrantes
* Ana Flavia de Oliveira Costa
* Bernardo Garcia Marques
* Diogo Campos Palhares
* Ivo Augusto Neves Dalcin

# Como rodar
Abra o arquivo POO-activities.sln no Visual Studio.
Compile e execute (Ctrl + F5).
