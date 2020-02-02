using System;

namespace Lab06
{
  public class Queue
  {
    private readonly int max;
    private int front;
    private int rear;
    private readonly double[] numbers;

    public int Front { get => front; }
    public int Rear { get => rear; }
    public bool IsFull { get => rear == max; }
    public bool IsEmpty { get => front == rear; }
    public int Count { get => rear - front; }

    public Queue() : this(100) { }
    public Queue(int max)
    {
      if (max <= 0)
        throw new ArgumentException("Kich thuoc hang doi phai lon hon 0!", nameof(max));

      this.max = max;
      front = 0;
      rear = 0;
      numbers = new double[max];
    }

    public void Enqueue(double number)
    {
      if (IsFull)
        throw new InvalidOperationException("Queue is full!");

      numbers[rear] = number;
      rear += 1;
    }
    public double Dequeue()
    {
      if (IsEmpty)
        throw new InvalidOperationException("Queue is empty!");

      var number = numbers[front];
      front += 1;
      if (front == rear)
        front = rear = 0;

      return number;
    }
    public double Top()
    {
      if (IsEmpty)
        throw new InvalidOperationException("Queue is empty!");

      return numbers[front];
    }
  }
}
