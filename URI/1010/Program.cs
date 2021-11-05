using System;
using System.Globalization;

namespace _1010
{
  class Program
  {
    static void Main(string[] args)
    {
      int p1, np1, p2, np2;
      double vp1, vp2, val_pag;

      string[] vet1 = Console.ReadLine().Split(' ');
      string[] vet2 = Console.ReadLine().Split(' ');

      p1 = int.Parse(vet1[0]);
      np1 = int.Parse(vet1[1]);
      vp1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

      p2 = int.Parse(vet2[0]);
      np2 = int.Parse(vet2[1]);
      vp2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

      val_pag = (np1 * vp1) + (np2 * vp2);

      Console.WriteLine("VALOR A PAGAR: R$ " + val_pag.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
