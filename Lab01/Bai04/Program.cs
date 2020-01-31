using System;

namespace Bai04
{
  public class PhanSo
  {
    private int _tuSo;
    private int _mauSo;

    public void Nhap()
    {
      Console.WriteLine("Nhap vao tu so: ");
      _tuSo = int.Parse(Console.ReadLine());

      Console.WriteLine("Nhap vao mau so: ");
      _mauSo = int.Parse(Console.ReadLine());
    }

    public override string ToString() => $"{_tuSo}/{_mauSo}";
  }
  class Program
  {
    static void Main(string[] args)
    {
      var phanSo = new PhanSo();
      try
      {
        phanSo.Nhap();
        Console.WriteLine($"Phan so vua nhap: {phanSo}");
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
