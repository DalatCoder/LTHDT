using System;

namespace Lab09
{
  public class SinhVien
  {
    private readonly string hoTenDem;
    private readonly string ten;
    private readonly string maSV;

    public string HoVaTen { get => this.ToString(); }
    public string HoDem { get => hoTenDem; }
    public string Ten { get => ten; }
    public string MaSinhVien { get => maSV; }

    public SinhVien(string hoTenDem, string ten, string maSV)
    {
      this.hoTenDem = hoTenDem;
      this.ten = ten;
      this.maSV = maSV;

      if (this.Validate() == false)
        throw new ArgumentException("Du lieu khong chinh xac!");
    }

    public bool Validate()
    {
      var flag = true;
      if (string.IsNullOrWhiteSpace(ten))
        flag = false;
      if (string.IsNullOrWhiteSpace(hoTenDem))
        flag = false;
      if (string.IsNullOrWhiteSpace(maSV))
        flag = false;
      return flag;
    }
    public override string ToString()
    => $"{hoTenDem} {ten}".Trim();
  }
}
