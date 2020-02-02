using System;

namespace Lab06
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        TestQueue();
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Co loi xay ra! {ex.Message}");
      }
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
