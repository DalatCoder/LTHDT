using System;
using System.Text;

namespace Lab05
{
  public class MaTran
  {
    private int row;
    private int col;
    private double[,] content;

    public int Row { get => row; }
    public int Col { get => col; }

    public MaTran() : this(0, 0) { }
    public MaTran(int row, int col)
    {
      this.row = row;
      this.col = col;
      content = new double[row, col];
    }

    public void Nhap()
    {
      Console.WriteLine("Nhap so hang cua ma tran: ");
      row = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap so cot cua ma tran: ");
      col = int.Parse(Console.ReadLine());

      content = new double[row, col];

      for (int i = 0; i < row; i++)
      {
        for (int j = 0; j < col; j++)
        {
          Console.Write($"Nhap gia tri [{i}, {j}] >> ");
          content[i, j] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine();
      }
    }

    public static MaTran operator +(MaTran a, MaTran b)
    {
      if (!MaTran.CungKichThuoc(a, b))
        throw new ArgumentException("2 ma tran khong cung kich thuoc!");

      var ketQua = new MaTran(a.row, a.col);

      for (int i = 0; i < a.row; i++)
        for (int j = 0; j < a.col; j++)
          ketQua.content[i, j] = a.content[i, j] + b.content[i, j];

      return ketQua;
    }

    public static MaTran operator *(MaTran a, MaTran b)
    {
      if (a.Col != b.Row)
        throw new ArgumentException("Kich thuoc 2 ma tran khong hop le!");

      throw new NotImplementedException();
    }

    public override string ToString()
    {
      var builder = new StringBuilder();
      builder.AppendLine();
      for (int i = 0; i < row; i++)
      {
        for (int j = 0; j < col; j++)
        {
          builder.Append(this.content[i, j]);
          builder.Append("  ");
        }
        builder.AppendLine();
      }

      return builder.ToString();
    }

    // Static methods
    public static bool CungKichThuoc(MaTran a, MaTran b)
      => (a.row == b.row) && (a.col == b.col);

    public static MaTran ChuyenVi(MaTran mt)
    {
      var mtChuyenVi = new MaTran(mt.col, mt.row);
      var max = mt.row * mt.col;
      var temp = new double[max];

      int index = 0;
      for (int i = 0; i < mt.row; i++)
        for (int j = 0; j < mt.col; j++)
        {
          temp[index] = mt.content[i, j];
          index += 1;
        }

      index = 0;
      for (int j = 0; j < mtChuyenVi.col; j++)
        for (int i = 0; i < mtChuyenVi.row; i++)
        {
          mtChuyenVi.content[i, j] = temp[index];
          index += 1;
        }

      return mtChuyenVi;
    }
  }
}
