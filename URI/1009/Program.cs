using System;
using System.Globalization;

namespace _1009
{
  class Program
  {
    static void Main(string[] args)
    {
      string nome;
      double sal, vend, total;

      nome = Console.ReadLine();
      sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      vend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      total = sal + (vend * 0.15);

      Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
