using System;
using System.Collections.Generic;

namespace Bai02
{
  public class Stack : ISQ
  {
    private List<double> stack;
    public Stack()
    {
      stack = new List<double>();
    }

    public int Lenght => stack.Count;
    public bool IsEmpty => Lenght == 0;

    public double Pop()
    {
      if (IsEmpty)
        throw new InvalidOperationException("Stack rong!");

      var number = stack[0];
      stack.RemoveAt(0);
      return number;
    }

    public void Push(double number)
    {
      stack.Insert(0, number);
    }

    public double Top()
    {
      if (IsEmpty)
        throw new InvalidOperationException("Stack rong!");
      return stack[0];
    }
  }
}
