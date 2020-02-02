using System;
using System.Linq;
using Xunit;
using Lab08;

namespace test
{
  public class NhiPhanTest
  {
    private const int soBit = 8;

    [Fact]
    public void KiemTra_Tao1DaySoNhiPhanTuConstructor()
    {
      var expected = new int[soBit] { 1, 1, 0, 1, 0, 0, 0, 0 }; // 00001101b = 11d

      var nhiPhan = new NhiPhan(11);
      var actual = nhiPhan.Bin.Cast<int>().ToArray();

      var isEqual = true;
      for (int i = 0; i < soBit; i++)
        if (expected[i] != actual[i])
        {
          isEqual = false;
          break;
        }

      Assert.True(isEqual);
    }
    [Fact]
    public void KiemTra_ChuyenSoThapPhanSangNhiPhan()
    {
      int dec = -30;

      var bin = new NhiPhan(dec);

      Assert.Equal(dec, bin.GetDecimal);
    }
    [Fact]
    public void KiemTra_ChuyenSoAmThapPhanSangNhiPhan()
    {
      //Given
      var expectedBin = new int[soBit] { 0, 0, 0, 1, 0, 0, 0, 1 };

      //When
      var actual = new NhiPhan(-8).Bin.Cast<int>().ToArray();

      //Then
      var isEqual = true;
      for (int i = 0; i < soBit; i++)
      {
        if (expectedBin[i] != actual[i])
        {
          isEqual = false;
          break;
        }
      }

      Assert.True(isEqual);
    }
    [Fact]
    public void TinhToan_Cong2SoNhiPhan_TraVeSoNhiPhanMoi()
    {
      var a = new NhiPhan(10);
      var b = new NhiPhan(20);

      var c = a + b;

      Assert.Equal(30, c.GetDecimal);
    }
    [Fact]
    public void TinhToan_Cong2SoNhiPhanTranVungNho_TraVeException()
    {
      //Given
      var a = new NhiPhan(127);
      var b = new NhiPhan(1);

      //When
      var actual = Assert.Throws<InvalidOperationException>(() => a + b);

      //Then
      Assert.Equal("Tran so nhi phan!", actual.Message);
    }
    [Fact]
    public void TinhToan_Cong2SoAmNhiPhanTranVungNho_TraVeException()
    {
      //Given
      var a = new NhiPhan(-127);
      var b = new NhiPhan(-1);

      //When
      var actual = Assert.Throws<InvalidOperationException>(() => a + b);

      //Then
      Assert.Equal("Tran so nhi phan!", actual.Message);
    }
    [Fact]
    public void TinhToan_Tru2SoNhiPhan_TraVeHieu()
    {
      //Given
      var a = new NhiPhan(127);
      var b = new NhiPhan(1);

      //When
      var c = a - b;

      //Then
      Assert.Equal(126, c.GetDecimal);
    }
    [Fact]
    public void TinhToan_Tru2SoNhiPhanTranVungNho_TraVeException()
    {
      //Given
      var a = new NhiPhan(-127);
      var b = new NhiPhan(1);

      //When
      var actual = Assert.Throws<InvalidOperationException>(() => a - b);

      //Then
      Assert.Equal("Tran so nhi phan!", actual.Message);
    }
  }
}
