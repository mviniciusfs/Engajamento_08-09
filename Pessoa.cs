using System;

class Pessoa
{
  private string nome;
  private int idade;
  private double peso, altura;

  public void Atributos(string n, int i, double p, double a)
  {
    nome = n;
    idade = i;
    peso = p;
    altura = a;
  }

  public void dadosPessoa()
  {
    Console.WriteLine("Nome: {0}\nIdade: {1}\nPeso: {2}\nAltura: {3}", nome, idade, peso, altura);
  }

  public void Envelhecer(int atual)
  {
    if (((atual - idade) > 0) && (idade < 21))
    {
      for (int i = atual - idade; i>0; i--)
      {
        Crescer(0.005);
      }
    }

    if (idade < atual)
    {
      idade = atual;
    }

    Console.WriteLine("Idade atual >> {0}",atual);
  }

  public void Engordar(double engordou)
  {
    if(engordou >= peso)
    {
      Console.WriteLine("Engordou >> {0} Kg", engordou - peso);
      peso = engordou;
      Console.WriteLine("Peso atual >> {0} Kg",peso);
      peso = engordou;
    }
    
    else
    {
      Console.WriteLine("Não engordou!");
    }
  }

  public void Emagrecer(double emagreceu)
  {
    if(emagreceu < peso)
    {
      Console.WriteLine("Emagreceu >> {0} Kg", peso - emagreceu);
      peso = emagreceu;
      Console.WriteLine("Peso atual >> {0} Kg",peso);
    }
    
    else
    {
      Console.WriteLine("Não emagreceu!");
    }
  }

  public void Crescer(double altura2)
  {
    if (altura2 == 0.005)
    {
      altura += altura2;
    } 
    
    else 
    {
      altura = altura2;
    }
  }

}



 


