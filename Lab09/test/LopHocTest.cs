using Xunit;
using Lab09;
using System.Collections.Generic;
using System;
using System.Linq;

namespace test
{
  public class LopHocTest
  {
    [Fact]
    public void TimKiem_TheoHoTen_TimThaySinhVien()
    {
      //Given
      var lopHoc = new LopHoc();
      lopHoc.NhapThongTin(new NhapDuLieuDeTest());
      var tigerTran = new SinhVien("Tran", "Dan", "3041975");

      //When
      List<SinhVien> danhSachSV = lopHoc.TimSinhVienTheoHoTen(tigerTran.HoVaTen).Cast<SinhVien>().ToList();

      //Then
      Assert.Equal(1, danhSachSV.Count);
      Assert.Equal(tigerTran.MaSinhVien, danhSachSV[0].MaSinhVien);
    }
    [Fact]
    public void TimKiem_TheoTen_TimThaySinhVien()
    {
      //Given
      var lopHoc = new LopHoc();
      lopHoc.NhapThongTin(new NhapDuLieuDeTest());
      var sv1 = new SinhVien("John", "Tom", "1212121");
      var sv2 = new SinhVien("Thomas", "Tom", "1111111");

      //When
      var danhSachSV = lopHoc.TimSinhVienTheoTen("Tom").Cast<SinhVien>().ToList();

      //Then
      Assert.Equal(2, danhSachSV.Count);
      Assert.NotNull(danhSachSV.Find(e => e.MaSinhVien.CompareTo(sv1.MaSinhVien) == 0));
      Assert.NotNull(danhSachSV.Find(e => e.MaSinhVien.CompareTo(sv2.MaSinhVien) == 0));
    }
    [Fact]
    public void TimKiem_TheoMaSo_TimThaySinhVien()
    {
      //Given
      var lopHoc = new LopHoc();
      lopHoc.NhapThongTin(new NhapDuLieuDeTest());
      var expected = new SinhVien("John", "Cena", "0000000");

      //When
      var actual = lopHoc.TimSinhVienTheoMaSo("0000000");

      //Then
      Assert.True(expected.MaSinhVien.CompareTo(actual.MaSinhVien) == 0);
    }
    [Fact]
    public void TimKiem_TheoHoTen_KhongTimThaySinhVien()
    {
      //Given
      var lopHoc = new LopHoc();
      lopHoc.NhapThongTin(new NhapDuLieuDeTest());
      var tigerTran = new SinhVien("Tran Ricardo", "Dan", "3041975");

      //When
      List<SinhVien> danhSachSV = lopHoc.TimSinhVienTheoHoTen(tigerTran.HoVaTen).Cast<SinhVien>().ToList();

      //Then
      Assert.Equal(0, danhSachSV.Count);
    }
    public void TimKiem_TheoTen_KhongTimThaySinhVien()
    {
      //Given
      var lopHoc = new LopHoc();
      lopHoc.NhapThongTin(new NhapDuLieuDeTest());

      //When
      var danhSachSV = lopHoc.TimSinhVienTheoTen("JohnCena").Cast<SinhVien>().ToList();

      //Then
      Assert.Equal(0, danhSachSV.Count);
    }
    [Fact]
    public void TimKiem_TheoMaSo_KhongTimThaySinhVien()
    {
      //Given
      var lopHoc = new LopHoc();
      lopHoc.NhapThongTin(new NhapDuLieuDeTest());
      var expected = new SinhVien("John", "Cena", "0000001");

      //When
      var actual = lopHoc.TimSinhVienTheoMaSo(expected.MaSinhVien);

      //Then
      Assert.True(actual is null);
    }
  }

  class NhapDuLieuDeTest : INhap
  {
    public IEnumerable<SinhVien> NhapDuLieu()
    {
      return new List<SinhVien>()
      {
        new SinhVien("Milos", "Ricardo", "1234321"),
        new SinhVien("John", "Cena", "0000000"),
        new SinhVien("Tran", "Dan", "3041975"),
        new SinhVien("Tran", "Tiger", "1581945"),
        new SinhVien("Thomas", "Tom", "1111111"),
        new SinhVien("Son", "Goku", "1111112"),
        new SinhVien("John", "Tom", "1212121")
      };
    }
  }
}
