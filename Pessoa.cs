using System;

class Pessoa
{
  public string Nome;
  public int Idade;
  public double Peso;
  public double Altura;


  public int Envelhecer(int i)
  {
    return Idade + i;
  } 

  public double Engordar(double p)
  {
    return Peso + p;
  }

  public double Emagrecer(double p)
  {
    return Peso - p;
  }

  public double Crescer(double l)
  {
    return l + 0.05;
  }
}