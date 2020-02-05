using System;

namespace Bai01
{
  public class Point2D
  {
    protected readonly int x;
    protected readonly int y;

    public Point2D(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    public virtual void Xuat() { Console.WriteLine($"{x}, {y}"); }
  }

  public class Point3D : Point2D
  {
    private int z;
    public Point3D(int x, int y, int z) : base(x, y)
    {
      this.z = z;
    }

    public override void Xuat() { Console.WriteLine($"{x}, {y}, {z}"); }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var p2 = new Point2D(1, 2);
      p2.Xuat();

      var p3 = new Point3D(1, 2, 3);
      p3.Xuat();
    }
  }
}
