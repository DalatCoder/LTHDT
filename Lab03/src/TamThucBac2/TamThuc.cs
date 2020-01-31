using System;

namespace TamThucBac2
{
  public class TamThuc
  {
    private int a;
    private int b;
    private int c;

    public TamThuc()
    {
      a = b = c = 0;
    }
    public TamThuc(int a, int b, int c)
    {
      this.a = a;
      this.b = b;
      this.c = c;
    }
    public TamThuc(TamThuc obj)
    {
      a = obj.a;
      b = obj.b;
      c = obj.c;
    }

    public void Nhap()
    {
      Console.WriteLine("Nhap he so a: ");
      a = int.Parse(Console.ReadLine());

      Console.WriteLine("Nhap he so b: ");
      b = int.Parse(Console.ReadLine());

      Console.WriteLine("Nhap he so c: ");
      c = int.Parse(Console.ReadLine());
    }

    public override string ToString()
      => $"{a}x^2 + {b}x + {c} = 0";

    public static TamThuc operator +(TamThuc t1, TamThuc t2)
      => new TamThuc(t1.a + t2.a, t1.b + t2.b, t1.c + t2.c);

    public static TamThuc operator -(TamThuc t1, TamThuc t2)
      => new TamThuc(t1.a - t2.a, t1.b - t2.b, t1.c - t2.c);

    public static TamThuc operator *(TamThuc t, int num)
      => new TamThuc(t.a * num, t.b * num, t.c * num);

    public static bool operator ==(TamThuc t1, TamThuc t2)
      => (t1.a == t2.a) && (t1.b == t2.b) && (t1.c == t2.c);

    public static bool operator !=(TamThuc t1, TamThuc t2)
      => !(t1 == t2);

    public static implicit operator TamThuc(int num)
    {
      var ketqua = new TamThuc();
      ketqua.c = num % 10; num /= 10;
      ketqua.b = num % 10; num /= 10;
      ketqua.a = num % 10;
      return ketqua;
    }
  }
}
