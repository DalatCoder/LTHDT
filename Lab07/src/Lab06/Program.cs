using System;

namespace Lab06
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        // TestQueue();
        TestDaThuc();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bam phim bat ki de thoat...");
        Console.ReadLine();
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Co loi xay ra! {ex.Message}");
      }
    }

    private static void TestDaThuc()
    {
      // ============ NHAP GIA TRI CHO DA THUC ============
      var a = new DaThuc(2);
      a.NhapDaThucTuBanPhim();
      Console.WriteLine($"Da thuc 1: {a}");

      var b = new DaThuc(3);
      b.NhapDaThucTuBanPhim();
      Console.WriteLine($"Da thuc 2: {b}");

      Console.WriteLine("Bam phim bat ki de tiep tuc...");
      Console.ReadLine();

      // ============ KIEM TRA DAO HAM DA THUC ============
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine($"Da thuc 1: {a}");
      Console.ResetColor();
      Console.WriteLine($"Dao ham: {a.DaoHam()}");

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine($"Da thuc 2: {b}");
      Console.ResetColor();
      Console.WriteLine($"Dao ham: {b.DaoHam()}");

      Console.WriteLine("Bam phim bat ki de tiep tuc...");
      Console.ReadLine();

      // ============ KIEM TRA PHEP TINH CONG TRU ============
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine($"Da thuc 1: {a}");
      Console.WriteLine($"Da thuc 2: {b}");
      Console.WriteLine();
      Console.WriteLine("Da thuc 1 + Da thuc 2 = ");
      Console.ResetColor();
      Console.WriteLine((a + b));

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Da thuc 1 - Da thuc 2 = ");
      Console.ResetColor();
      Console.WriteLine((a - b));

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Da thuc 2 - Da thuc 1 = ");
      Console.ResetColor();
      Console.WriteLine((b - a));
    }

    private static void TestQueue()
    {
      int max = 10;
      var queue = new Queue(max);
      for (int i = 0; i < max; i++)
        queue.Enqueue(i);

      Console.WriteLine("So phan tu trong hang doi: " + queue.Count);
      var index = queue.Front;
      while (!queue.IsEmpty)
      {
        Console.WriteLine(queue.Dequeue());
      }
    }
  }
}
