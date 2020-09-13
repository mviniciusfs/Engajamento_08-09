using System;

/*
Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhecer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.
*/

class MainClass {
  public static void Main (string[] args) {
    Pessoa p = new Pessoa();

    p.Atributos("Teste", 16, 85, 1.83);

    p.dadosPessoa();    

    Console.WriteLine();

    p.Envelhecer(20);
    p.Engordar(86);
    p.dadosPessoa();

    Console.WriteLine();

    p.Emagrecer(80);
    //p.Crescer(1.85);
    p.dadosPessoa();
  }
}