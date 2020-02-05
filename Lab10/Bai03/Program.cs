using System;

namespace Bai03
{
  public class HinhTron
  {
    private readonly double r;
    public HinhTron(double rad)
    {
      r = rad;
    }

    public double BanKinh { get => r; }
    public double DienTich { get => Math.PI * Math.Pow(r, 2); }
  }

  public class HinhCau : HinhTron
  {
    private readonly double r;
    public HinhCau(double r) : base(r)
    {
      this.r = r;
    }

    public new double BanKinh { get => r; }
    public new double DienTich { get => 4 * Math.PI * Math.Pow(r, 2); }
    public double TheTich { get => (4 / 3) * Math.PI * Math.Pow(r, 2); }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var tron = new HinhTron(2);
      Console.WriteLine($"Dien tich hinh tron ban kinh 2: {tron.DienTich}");

      var cau = new HinhCau(2);
      Console.WriteLine($"Dien tich hinh cau co ban kinh 2: {cau.BanKinh}");
      Console.WriteLine($"The tich hinh cau co ban kinh 2: {cau.TheTich}");
    }
  }
}
