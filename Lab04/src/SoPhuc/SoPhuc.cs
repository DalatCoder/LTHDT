using System;

namespace SoPhuc
{
  public class SoPhuc
  {
    // a + bi
    private int a;
    private int b;

    public SoPhuc() { }
    public SoPhuc(int a, int b)
    {
      this.a = a;
      this.b = b;
    }
    public SoPhuc(SoPhuc obj)
    {
      this.a = obj.a;
      this.b = obj.b;
    }

    public int PhanThuc { get => a; }
    public int PhanAo { get => b; }

    public void Nhap()
    {
      Console.WriteLine("Nhap vao phan thuc: ");
      a = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap vao phan ao: ");
      b = int.Parse(Console.ReadLine());
    }

    public bool LaSoThuc() => b == 0;
    public bool LaSoThuanAo() => a == 0;

    public static SoPhuc operator +(SoPhuc sp1, SoPhuc sp2)
      => new SoPhuc(sp1.a + sp2.a, sp1.b + sp2.b);

    public static SoPhuc operator -(SoPhuc x, SoPhuc y)
      => new SoPhuc(x.a - y.a, x.b - y.b);

    public static SoPhuc operator *(SoPhuc sp1, SoPhuc sp2)
    {
      var a = sp1.a * sp2.a - sp1.b * sp2.b;
      var b = sp1.a * sp2.b + sp1.b * sp2.a;
      return new SoPhuc(a, b);
    }

    public static bool operator ==(SoPhuc sp1, SoPhuc sp2)
      => (sp1.a == sp2.a) && (sp1.b == sp2.b);

    public static bool operator !=(SoPhuc sp1, SoPhuc sp2)
      => !(sp1 == sp2);

    public override string ToString()
      => $"{a} + {b}i";
  }
}
