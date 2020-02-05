using System;

namespace Bai02
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Test stack!");
      Test(new Stack());

      Console.WriteLine("Test queue");
      Test(new Queue());
    }

    private static void Test(ISQ stack)
    {

      // Nhap
      int max = 10;
      for (int i = 0; i < max; i++)
      {
        stack.Push(i);
      }

      // Xuat
      Console.WriteLine($"So luong phan tu hien tai truoc khi Pop(): {max}");
      for (int i = 0; i < max; i++)
      {
        Console.Write(stack.Pop() + "  ");
      }
      Console.WriteLine();

      // Kiem tra properties
      Console.WriteLine($"So luong phan tu con lai: {stack.Lenght}");
    }
  }
}
