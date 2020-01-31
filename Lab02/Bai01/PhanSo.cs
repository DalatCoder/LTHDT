namespace Bai01
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
    public PhanSo(PhanSo obj)
    {
      _tuSo = obj.TuSo;
      _mauSo = obj.MauSo;
    }

    public int TuSo { get => _tuSo; }
    public int MauSo { get => _mauSo; }

    public override string ToString() => $"{_tuSo}/{_mauSo}";
  }
}
