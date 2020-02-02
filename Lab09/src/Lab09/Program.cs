using System;

namespace Lab09
{
  class Program
  {
    static void Main(string[] args)
    {
      var ctk42 = new LopHoc();
      ctk42.NhapThongTin(new NhapDuLieuTuBanPhim());
      Console.WriteLine($"Si so lop hoc: {ctk42.SiSoLopHoc}");
      Console.WriteLine($"Danh sach lop hoc: {ctk42}");
    }
  }
}
