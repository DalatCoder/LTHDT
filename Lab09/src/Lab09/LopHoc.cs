using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{
  public interface INhap
  {
    IEnumerable<SinhVien> NhapDuLieu();
  }

  public class NhapDuLieuTuBanPhim : INhap
  {
    public IEnumerable<SinhVien> NhapDuLieu()
    {
      var danhSachSV = new List<SinhVien>();

      var index = 1;

      while (true)
      {
        Console.WriteLine($"Nhap thong tin sinh vien {index}: ");
        var hoTenDem = NhapThongTin("Nhap ho va ten dem >> ");
        var ten = NhapThongTin("Nhap ten >> ");
        var maSV = NhapThongTin("Nhap ma so >> ");

        danhSachSV.Add(new SinhVien(hoTenDem, ten, maSV));

        Console.Write("Co muon tiep tuc (c/k) >> ");
        var choose = Console.ReadLine();
        if (choose.ToLower().CompareTo("k") == 0)
          break;
      }

      return danhSachSV;
    }

    private string NhapThongTin(string message)
    {
      string str = string.Empty;
      while (string.IsNullOrWhiteSpace(str))
      {
        Console.WriteLine(message);
        str = Console.ReadLine();
      }
      return str;
    }
  }

  public class LopHoc
  {
    private List<SinhVien> danhSachSV;

    public int SiSoLopHoc { get => danhSachSV.Count; }
    public IEnumerable<SinhVien> DanhSachSV { get => danhSachSV; }

    public LopHoc()
    {
      this.danhSachSV = new List<SinhVien>();
    }
    public LopHoc(List<SinhVien> danhSachSV)
    {
      this.danhSachSV = new List<SinhVien>(danhSachSV);
    }

    public void Them1SinhVien(SinhVien sinhVien)
    {
      if (!sinhVien.Validate())
        throw new ArgumentException("Du lieu khong hop le!", nameof(sinhVien));

      danhSachSV.Add(sinhVien);
    }

    public void NhapThongTin(INhap nhap)
    {
      danhSachSV = nhap.NhapDuLieu().Cast<SinhVien>().ToList();
    }

    public IEnumerable<SinhVien> TimSinhVienTheoHoTen(string hoTen)
      => danhSachSV.FindAll(sv => sv.HoVaTen.CompareTo(hoTen) == 0);

    public IEnumerable<SinhVien> TimSinhVienTheoTen(string ten)
      => danhSachSV.FindAll(sv => sv.Ten.CompareTo(ten) == 0);

    public SinhVien TimSinhVienTheoMaSo(string maSo)
      => danhSachSV.Find(sv => sv.MaSinhVien.CompareTo(maSo) == 0);

    public bool XoaSinhVienTheoMaSo(string maSo)
    {
      var sinhVien = TimSinhVienTheoMaSo(maSo);
      if (sinhVien is null)
        return false;
      danhSachSV.Remove(sinhVien);
      return true;
    }

    public override string ToString()
    {
      var builder = new StringBuilder();
      builder.AppendLine();

      foreach (var sinhVien in danhSachSV)
      {
        builder.Append(sinhVien.MaSinhVien + " - ");
        builder.AppendLine(sinhVien.HoVaTen);
      }

      return builder.ToString();
    }
  }
}
