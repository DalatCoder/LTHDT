using System;
using System.Text;

namespace Lab05
{
  class Program
  {
    static void Main()
    {
      try
      {
        // TestStack_Lab05_Bai1();

        TestMaTran();

        Console.WriteLine("Bam phim bat ki de thoat...");
        Console.ReadLine();
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Co loi xay ra! {ex.Message}");
        Program.Main();
      }
    }

    private static void TestMaTran()
    {
      Console.WriteLine("Nhap ma tran thu nhat: ");
      var mt1 = new MaTran();
      mt1.Nhap();
      Console.WriteLine($"Ma tran thu nhat: {mt1}");

      Console.WriteLine("Nhap ma tran thu hai: ");
      var mt2 = new MaTran();
      mt2.Nhap();
      Console.WriteLine($"Ma tran thu hai: {mt2}");

      var mt3 = mt1 + mt2;
      Console.WriteLine($"Ma tran 1 + ma tran 2 = {mt3}");

      System.Console.WriteLine($"Ma tran 1 ban dau: {mt1}");
      mt1 = MaTran.ChuyenVi(mt1);
      System.Console.WriteLine($"Ma tran 1 sau khi chuyen vi: {mt1}");
    }

    private static void TestStack_Lab05_Bai1()
    {
      Console.WriteLine("Nhap vao 1 so thap phan: ");
      var dec = int.Parse(Console.ReadLine());

      ThapPhanSangNhiPhan(dec);
      ThapPhanSangThapLucPhan(dec);
    }

    private static void ThapPhanSangThapLucPhan(int dec)
    {
      var stack = new Stack(100);
      while (dec != 0)
      {
        stack.Push(dec % 16);
        dec /= 16;
      }

      Console.WriteLine("Day so thap luc phan tuong ung: ");
      var hex = new StringBuilder();
      while (!stack.IsEmpty)
      {
        hex.Append(LayGiaTriHexTuongUng((int)stack.Pop()));
      }
      Console.WriteLine(hex.ToString());
    }

    private static string LayGiaTriHexTuongUng(int dec)
    {
      if (dec < 10) return dec.ToString();
      else
      {
        switch (dec)
        {
          case 10: return "A";
          case 11: return "B";
          case 12: return "C";
          case 13: return "D";
          case 14: return "E";
          case 15: return "F";
        }
      }

      throw new ArgumentException("Khong the chuyen doi sang he 16!", nameof(dec));
    }

    private static void ThapPhanSangNhiPhan(int dec)
    {
      var stack = new Stack(100);
      while (dec != 0)
      {
        stack.Push(dec % 2);
        dec /= 2;
      }

      Console.WriteLine("Day so nhi phan tuong ung: ");
      var builder = new StringBuilder();
      while (!stack.IsEmpty)
      {
        builder.Append(stack.Pop());
      }
      Console.WriteLine(builder.ToString());
    }
  }
}
