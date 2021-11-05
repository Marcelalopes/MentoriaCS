using System;
using System.Globalization;


namespace _1006
{
  class Program
  {
    static void Main(string[] args)
    {
      double A, B, C, m;
      A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      m = ((A * 2) + (B * 3) + (C * 5)) / 10;
      Console.WriteLine("MEDIA = " + m.ToString("F1", CultureInfo.InvariantCulture));
    }
  }
}
