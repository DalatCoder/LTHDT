using System;

namespace Bai07
{
  class Program
  {
    static void Main(string[] args)
    {
      var a = new PhanSo(2, 3);
      var b = new PhanSo(3, 4);

      Console.WriteLine($"Phan so a: {a}");
      Console.WriteLine($"Phan so b: {b}");

      Console.WriteLine("-a: {0}", -a); // -2/3
      Console.WriteLine("++a: {0}", ++a);
      Console.WriteLine("--a: {0}", --a);
      Console.WriteLine("a + b: {0}", a + b);
      Console.WriteLine("a - b: {0}", a - b);
      Console.WriteLine("a * b: {0}", a * b);
      Console.WriteLine("a / b: {0}", a / b);
    }
  }
}
