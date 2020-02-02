using System;
using Xunit;
using Lab09;

namespace test
{
  public class SinhVienTest
  {
    [Fact]
    public void Tao1DoiTuongSinhVienVaKiemTraThongTin()
    {
      var sv = new SinhVien("Nguyen", "Hieu", "1812756");

      var expectedName = "Nguyen Hieu";
      var expectedId = "1812756";

      var actualName = sv.HoVaTen;
      var actualId = sv.MaSinhVien;

      Assert.Equal(expectedName, actualName);
      Assert.Equal(expectedId, actualId);
    }
    [Fact]
    public void Tao1DoiTuongSinhVienThieuHoTenDem_TraVeException()
    {
      //Given
      var expectedExceptionMessage = "Du lieu khong chinh xac!";

      //When
      var exception = Assert.Throws<ArgumentException>(() => new SinhVien("", "Hieu", "1812756"));

      //Then
      Assert.Equal(expectedExceptionMessage, exception.Message);
    }
    [Fact]
    public void Tao1DoiTuongSinhVienKhongHopLe_TraVeException()
    {
      //Given
      var expectedExceptionMessage = "Du lieu khong chinh xac!";

      //When
      var exception = Assert.Throws<ArgumentException>(() => new SinhVien("", "", ""));

      //Then
      Assert.Equal(expectedExceptionMessage, exception.Message);
    }
  }
}
