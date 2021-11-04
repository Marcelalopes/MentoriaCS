using System;

namespace MyTeste
{
  class Program
  {
    static void Main(string[] args)
    {
      int idade;
      Console.Write("Digite sua idade: ");//saída sem quebra de linha
      idade = int.Parse(Console.ReadLine());//entrada

      Console.WriteLine("Idade: " + idade);//saída com quebra de linha
      Console.WriteLine($"Idade: {idade}");
    }
  }
}
