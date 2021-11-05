using System;

namespace MediaAritmetica
{
  class Program
  {
    static void Main(string[] args)
    {
      string name, resultado;
      float n1, n2, n3, m_min, m;

      Console.Write("Digite seu nome: ");
      name = Console.ReadLine();

      Console.WriteLine("Digite suas notas: ");
      n1 = float.Parse(Console.ReadLine());
      n2 = float.Parse(Console.ReadLine());
      n3 = float.Parse(Console.ReadLine());

      Console.Write("Qual a média mínima para ser aprovado? ");
      m_min = float.Parse(Console.ReadLine());

      m = (n1 + n2 + n3) / 3;

      resultado = (m >= m_min) ?
      "você foi aprovado!" : "você foi reprovado!";
      Console.Write(name + " " + resultado);
    }
  }
}
