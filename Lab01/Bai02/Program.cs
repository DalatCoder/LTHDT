using System;

namespace Bai02
{
  public class MyClass
  {
    public int A;

    public void Set_A(int num) => A = num;
    public int Get_A() => A;
  }

  class Program
  {
    static void Main(string[] args)
    {
      var obj1 = new MyClass();
      var obj2 = new MyClass();

      obj1.A = 10;
      obj2.Set_A(99);

      Console.WriteLine($"Gia tri a cua obj1 la: {obj1.A}");
      Console.WriteLine($"Gia tri a cua obj2 la: {obj2.Get_A()}");

      Console.ReadLine();
    }
  }
}


/*
* Su dung public nghia la object cua class co the truy cap va sua
* doi du lieu ben ngoai class.
* Su dung private access modifier the hien tinh bao dong cua lap
* trinh huong doi tuong.
*/
