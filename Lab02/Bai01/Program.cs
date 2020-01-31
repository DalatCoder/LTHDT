using System;

namespace Bai01
{
  class Program
  {
    static void Main(string[] args)
    {
      var ps1 = new PhanSo(2, 5);
      Console.WriteLine($"Gia tri cua phan so 1: {ps1}");

      var ps2 = new PhanSo(ps1);
      Console.WriteLine($"Gia tri cua phan so 2: {ps2}");

      Console.ReadLine();
    }
  }
}
