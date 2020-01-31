using System;

namespace Bai07
{
  public class PhanSo
  {
    private readonly int tuSo;
    private readonly int mauSo;

    public PhanSo(int tuSo, int mauSo)
    {
      if (mauSo == 0)
        throw new ArgumentException("Mau so phai khac 0", nameof(mauSo));
      this.tuSo = tuSo;
      this.mauSo = mauSo;
    }

    public static PhanSo operator +(PhanSo a) => a;
    public static PhanSo operator -(PhanSo a) => new PhanSo(-a.tuSo, a.mauSo);

    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
      var tuSo = a.tuSo * b.mauSo + b.tuSo * a.mauSo;
      var mauSo = a.mauSo * b.mauSo;

      return new PhanSo(tuSo, mauSo);
    }

    public static PhanSo operator -(PhanSo a, PhanSo b)
      => a + (-b); // Cong cho so doi

    public static PhanSo operator *(PhanSo a, PhanSo b)
      => new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);

    public static PhanSo operator /(PhanSo a, PhanSo b)
    {
      if (b.tuSo == 0)
        throw new DivideByZeroException();
      return new PhanSo(a.tuSo * b.mauSo, b.tuSo * a.mauSo);
    }

    public static bool operator ==(PhanSo a, PhanSo b)
    {
      var c = a - b;
      return Math.Abs(c.tuSo / c.mauSo) == 0;
    }

    public static bool operator !=(PhanSo a, PhanSo b)
       => !(a == b);

    public static PhanSo operator ++(PhanSo a)
      => a + new PhanSo(1, 1);

    public static PhanSo operator --(PhanSo a)
      => a - new PhanSo(1, 1);

    public override string ToString()
      => $"{tuSo} / {mauSo}";
  }
}
