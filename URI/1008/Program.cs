using System;
using System.Globalization;

namespace _1008
{
  class Program
  {
    static void Main(string[] args)
    {
      int n, h;
      float sh, s;
      n = int.Parse(Console.ReadLine());
      h = int.Parse(Console.ReadLine());
      sh = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      s = sh * h;

      Console.WriteLine($"NUMBER = {n}");
      Console.WriteLine("SALARY = U$ " + s.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
