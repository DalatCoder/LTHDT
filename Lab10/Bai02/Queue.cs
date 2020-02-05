using System;
using System.Collections.Generic;

namespace Bai02
{
  public class Queue : ISQ
  {
    private readonly List<double> queue;
    public Queue()
    {
      queue = new List<double>();
    }

    public int Lenght => queue.Count;

    public bool IsEmpty => Lenght == 0;

    public double Pop()
    {
      if (IsEmpty)
        throw new InvalidOperationException("Queue rong!");

      var number = queue[0];
      queue.RemoveAt(0);
      return number;
    }

    public void Push(double number)
    {
      queue.Add(number);
    }

    public double Top()
    {
      if (IsEmpty)
        throw new InvalidOperationException("Queue rong!");

      return queue[0];
    }
  }
}
