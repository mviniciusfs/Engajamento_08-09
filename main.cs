using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa p = new Pessoa();

    p.Nome = "Marcos";
    p.Idade = 20;
    p.Peso = 85;
    p.Altura = 1.85;

    Console.WriteLine(p.Crescer(p.Altura));
  }
}