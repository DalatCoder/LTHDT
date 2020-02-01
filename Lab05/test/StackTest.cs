using System;
using Lab05;
using Xunit;

namespace test
{
  public class StackTest
  {
    [Fact]
    public void KiemTra_ChieuDaiCuaStack()
    {
      //Given
      var stack = new Stack(10);
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      var expected = 3;

      //When
      var actual = stack.Length;

      //Then
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void KiemTra_StackRong_TraVeTrue()
    {
      var stack = new Stack();
      Assert.True(stack.IsEmpty);
    }

    [Fact]
    public void KiemTra_StackRong_TraVeFalse()
    {
      var stack = new Stack();
      stack.Push(1);
      Assert.False(stack.IsEmpty);
    }

    [Fact]
    public void KiemTra_StackFull_TraVeTrue()
    {
      int max = 100;
      var stack = new Stack(max);

      for (int i = 0; i < max; i++)
        stack.Push(i);

      Assert.True(stack.IsFull);
    }

    [Fact]
    public void KiemTra_StackFull_TraVeFalse()
    {
      var stack = new Stack();
      Assert.False(stack.IsFull);
    }

    [Fact]
    public void ThaoTac_PushThemPhanTuVaoDauStack()
    {
      // --Arrange
      var stack = new Stack(10);
      stack.Push(1);

      var expected = 1;

      // --Act
      var actual = stack.Top;

      // --Assert
      Assert.Equal(expected, actual);
      Assert.Equal(1, stack.Length);
    }

    [Fact]
    public void ThaoTac_Pop1PhanTuKhoiStack()
    {
      // --Arrange
      var stack = new Stack(10);
      stack.Push(1);

      var expected = 1;

      // --Act
      var actual = stack.Pop();

      // --Assert
      Assert.Equal(expected, actual);
      Assert.Equal(0, stack.Length);
    }

    [Fact]
    public void ThaoTac_TaoStackVoiSoPhanTuLa0HoacSoAm_TraVeException()
    {
      var expectedMsg = "So phan tu cua stack khong hop le! (Parameter 'max')";

      var actual = Assert.Throws<ArgumentException>(() => new Stack(0));

      Assert.Equal(expectedMsg, actual.Message);
    }

    [Fact]
    public void ThaoTac_Pop1PhanTuKhiStackRong_TraVeException()
    {
      var stack = new Stack();
      var expectedMsg = "Stack rong!";

      var actual = Assert.Throws<InvalidOperationException>(() => stack.Pop());
      Assert.Equal(expectedMsg, actual.Message);
    }

    [Fact]
    public void ThaoTac_Push1PhanTuKhiStackFull_TraVeException()
    {
      int max = 10;
      var stack = new Stack(max);

      for (int i = 0; i < max; i++)
        stack.Push(i);

      var expectedMsg = "Stack full!";

      var actual = Assert.Throws<InvalidOperationException>(() => stack.Push(69));
      Assert.Equal(expectedMsg, actual.Message);
    }
  }
}
