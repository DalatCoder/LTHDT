using System;
using System.Text;

namespace Lab06
{
  public class DaThuc
  {
    private readonly int n;
    private readonly double[] content;

    public int BacDaThuc { get => n; }

    public DaThuc(int bacCaoNhat)
    {
      this.n = bacCaoNhat;
      content = new double[bacCaoNhat + 1];
    }
    public DaThuc(params double[] danhSachHeSo)
    {
      this.n = danhSachHeSo.Length - 1;
      content = new double[n + 1];

      var index = 0;
      for (int i = n; i >= 0; i--)
        content[i] = danhSachHeSo[index++];
    }

    public void NhapDaThucTuBanPhim()
    {
      for (int i = n; i >= 0; i--)
      {
        Console.Write($"Nhap he so cua x^{i} >> ");
        content[i] = double.Parse(Console.ReadLine());
      }
    }
    public DaThuc DaoHam()
    {
      var ketQua = new DaThuc(this.BacDaThuc - 1);
      for (int i = this.BacDaThuc; i > 0; i--)
      {
        ketQua.content[i - 1] = this.content[i] * i;
      }
      return ketQua;
    }

    public static DaThuc operator +(DaThuc a, DaThuc b)
    {
      int bacDaThucCaoHon = (a.BacDaThuc > b.BacDaThuc) ? a.BacDaThuc : b.BacDaThuc;
      int bacDaThucThapHon = (a.BacDaThuc < b.BacDaThuc) ? a.BacDaThuc : b.BacDaThuc;
      var daThucTong = new DaThuc(bacDaThucCaoHon);

      for (int i = 0; i <= bacDaThucThapHon; i++)
      {
        daThucTong.content[i] = a.content[i] + b.content[i];
      }

      if (a.BacDaThuc == bacDaThucCaoHon)
      {
        for (int i = bacDaThucThapHon + 1; i <= bacDaThucCaoHon; i++)
          daThucTong.content[i] = a.content[i];
      }
      else
      {
        for (int i = bacDaThucThapHon + 1; i <= bacDaThucCaoHon; i++)
          daThucTong.content[i] = b.content[i];
      }

      return daThucTong;
    }
    public static DaThuc operator -(DaThuc a, DaThuc b)
    {
      int bacDaThucCaoHon = (a.BacDaThuc > b.BacDaThuc) ? a.BacDaThuc : b.BacDaThuc;
      int bacDaThucThapHon = (a.BacDaThuc < b.BacDaThuc) ? a.BacDaThuc : b.BacDaThuc;
      var daThucTong = new DaThuc(bacDaThucCaoHon);

      for (int i = 0; i <= bacDaThucThapHon; i++)
      {
        daThucTong.content[i] = a.content[i] - b.content[i];
      }

      if (a.BacDaThuc == bacDaThucCaoHon)
      {
        for (int i = bacDaThucThapHon + 1; i <= bacDaThucCaoHon; i++)
          daThucTong.content[i] = a.content[i];
      }
      else
      {
        for (int i = bacDaThucThapHon + 1; i <= bacDaThucCaoHon; i++)
          daThucTong.content[i] = (-b.content[i]);
      }

      return daThucTong;
    }

    public static bool operator ==(DaThuc a, DaThuc b)
    {
      if (a.BacDaThuc != b.BacDaThuc) return false;

      for (int i = 0; i <= a.BacDaThuc; i++)
        if (a.content[i] != b.content[i])
          return false;

      return true;
    }
    public static bool operator !=(DaThuc a, DaThuc b)
      => !(a == b);
    public override string ToString()
    {
      var builder = new StringBuilder();
      for (int i = n; i > 0; i--)
      {
        builder.Append(content[i]);
        builder.Append($"x^{i} + ");
      }
      builder.Append(content[0]);
      return builder.ToString();
    }
  }
}
