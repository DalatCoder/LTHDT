using System;

namespace Bai01
{
  public class MyClass
  {
    public int A { get; set; }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var obj1 = new MyClass();
      var obj2 = new MyClass();

      obj1.A = 10;
      obj2.A = 99;

      Console.WriteLine($"Gia tri cua doi tuong obj1: {obj1.A}");
      Console.WriteLine($"Gia tri cua doi tuong obj2: {obj2.A}");

      Console.ReadLine();
    }
  }
}

/*
* Nhan xet 2 doi tuong:
* Thanh phan cua 2 doi tuong obj1 va obj2 giong nhau
*/
