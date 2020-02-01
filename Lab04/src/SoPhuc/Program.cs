using System;

namespace SoPhuc
{
  public class Program
  {
    static void Main(string[] args)
    {
      try
      {
        var sp1 = new SoPhuc();
        var sp2 = new SoPhuc();

        NhapGiaTriSoPhuc(sp1, sp2);
        KiemTraTinhToan(sp1, sp2);
      }
      catch (FormatException ex)
      {
        Console.WriteLine("Vui long nhap vao 1 so nguyen!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Co loi xay ra!");
      }
    }

    private static void NhapGiaTriSoPhuc(SoPhuc sp1, SoPhuc sp2)
    {
      Console.WriteLine("Nhap vao so phuc dau tien");
      sp1.Nhap();

      Console.WriteLine("Nhap vao so phuc thu hai");
      sp2.Nhap();
    }

    private static void KiemTraTinhToan(SoPhuc sp1, SoPhuc sp2)
    {
      Console.WriteLine($"So phuc 1: {sp1}");
      Console.WriteLine($"So phuc 2: {sp2}");

      Console.WriteLine($"({sp1}) + ({sp2}) = {sp1 + sp2}");
      Console.WriteLine($"({sp1}) - ({sp2}) = {sp1 - sp2}");
      Console.WriteLine($"({sp1}) * ({sp2}) = {sp1 * sp2}");
      Console.WriteLine($"({sp1}) == ({sp2}) ? {(sp1 == sp2 ? "Dung" : "Khong dung")}");
      Console.WriteLine($"({sp1}) != ({sp2}) ? {(sp1 != sp2 ? "Dung" : "Khong dung")}");
    }
  }
}
