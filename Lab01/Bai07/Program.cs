using System;

namespace Bai07
{
  class Program
  {
    static void Main(string[] args)
    {
      var phanSo_1 = new PhanSo();
      Console.WriteLine($"Gia tri cua phan so 1: {phanSo_1}");

      var phanSo_2 = new PhanSo(10);
      Console.WriteLine($"Gia tri cua phan so 2: {phanSo_2}");

      var phanSo_3 = new PhanSo(10, 20);
      Console.WriteLine($"Gia tri cua phan so 3: {phanSo_3}");

      Console.ReadLine();
    }
  }
}
