using Xunit;
using Lab06;

namespace test
{
  public class DaThucTest
  {
    [Fact]
    public void TinhToan_DaThucBacThapTruDaThucBacCao_TraVeDaThucHieu()
    {
      //Given
      var daThucBacThap = new DaThuc(3, 2, 1); // 3x^2 + 2x^1 + 1
      var daThucBacCao = new DaThuc(4, 3, 2, 1); // 4x^3 + 3x^2 + 2x^1 + 1

      var daThucHieu = new DaThuc(-4, 0, 0, 0); // -4x^3

      //When
      var actual = daThucBacThap - daThucBacCao;

      //Then
      Assert.True(daThucHieu == actual);
    }
    [Fact]
    public void TinhToan_DaThucBacCaoTruDaThucBacThap_TraVeDaThucHieu()
    {
      //Given
      var daThucBacThap = new DaThuc(3, 2, 1); // 3x^2 + 2x^1 + 1
      var daThucBacCao = new DaThuc(4, 4, 3, 1); // 4x^3 + 3x^2 + 2x^1 + 1

      var daThucHieu = new DaThuc(4, 1, 1, 0); // 4x^3

      //When
      var actual = daThucBacCao - daThucBacThap;

      //Then
      Assert.True(daThucHieu == actual);
    }
    [Fact]
    public void TinhToan_Cong2DaThuc_TraVeDaThucTong()
    {
      //Given
      var daThucBacThap = new DaThuc(3, 2, 1); // 3x^2 + 2x^1 + 1
      var daThucBacCao = new DaThuc(4, 4, 3, 1); // 4x^3 + 3x^2 + 2x^1 + 1

      var daThucHieu = new DaThuc(4, 7, 5, 2); // 4x^3 + 7x^2 + 5x^1 + 2

      //When
      var actual = daThucBacCao + daThucBacThap;

      //Then
      Assert.True(daThucHieu == actual);
    }
    [Fact]
    public void ThaoTac_DaoHamCap1DaThuc_TraVeDaThucDaoHam()
    {
      //Given
      var daThuc = new DaThuc(4, 7, 0, 7, 1, 2);// 4x5 +7x4 +7x2 +x+2
      var daThucDaoHam = new DaThuc(20, 28, 0, 14, 1);

      //When
      var actual = daThuc.DaoHam();

      //Then
      Assert.True(daThucDaoHam == actual);
    }
  }
}
