using System;

namespace Bai03
{
  public class HCN
  {
    private int _chieuDai;
    private int _chieuRong;

    public void SetHCN()
    {
      Console.WriteLine("Nhap chieu dai: ");
      _chieuDai = int.Parse(Console.ReadLine());

      Console.WriteLine("Nhap chieu rong: ");
      _chieuRong = int.Parse(Console.ReadLine());
    }

    public int TinhChuVi() => (_chieuDai + _chieuRong) * 2;
    public int TinhDienTich() => _chieuDai * _chieuRong;
  }

  class Program
  {
    static void Main(string[] args)
    {
      var hcn = new HCN();

      try
      {
        hcn.SetHCN();

        Console.WriteLine($"Chu vi HCN: {hcn.TinhChuVi()}");
        Console.WriteLine($"Dien tich HCN: {hcn.TinhDienTich()}");

        Console.ReadLine();
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
  }
}
