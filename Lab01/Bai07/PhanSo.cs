namespace Bai07
{
  public class PhanSo
  {
    private int _tuSo;
    private int _mauSo;

    public PhanSo()
    {
      _tuSo = 0;
      _mauSo = 1;
    }
    public PhanSo(int tuSo)
    {
      _tuSo = tuSo;
      _mauSo = 1;
    }
    public PhanSo(int tuSo, int mauSo)
    {
      _tuSo = tuSo;
      _mauSo = mauSo;
    }

    public override string ToString() => $"{_tuSo}/{_mauSo}";
  }
}
