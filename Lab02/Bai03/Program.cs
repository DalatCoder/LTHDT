using System;

namespace Bai03
{
  public static class TienIch
  {
    public static double TinhLuyThua(int coSo, int soMu) => Math.Pow(coSo, soMu);

    public static int TimUCLN(int a, int b)
    {
      if (a == 0 || b == 0) return a + b;
      while (a != b)
      {
        if (a > b) a = a - b;
        else b = b - a;
      }
      return a;
    }

    public static int TimBCNN(int a, int b) => (a * b) / TimUCLN(a, b);
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(TienIch.TinhLuyThua(2, 3));
      Console.WriteLine($"UCLN cua 20 va 30 la: {TienIch.TimUCLN(20, 30)}");
      Console.WriteLine($"BCNN cua 20 va 30 la: {TienIch.TimBCNN(20, 30)}");

      Console.ReadLine();
    }
  }
}
