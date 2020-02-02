using System;
using Xunit;
using Lab06;

namespace test
{
  public class QueueTest
  {
    [Fact]
    public void KiemTra_KhiHangDoiRongThiResetFrontVaRear_FrontVaRearBang0()
    {
      //Given
      var queue = new Queue(3);
      queue.Enqueue(1);
      queue.Enqueue(2);

      //When
      queue.Dequeue();
      queue.Dequeue();

      //Then
      Assert.Equal(0, queue.Front);
      Assert.Equal(0, queue.Rear);
    }
    [Fact]
    public void ThaoTac_TaoHangDoiVoiSoPhanTuNhoHonHoacBang0_TraVeException()
    {
      //Given
      var expectedMsg = "Kich thuoc hang doi phai lon hon 0! (Parameter 'max')";

      //When
      var actual = Assert.Throws<ArgumentException>(() => new Queue(-100));

      //Then
      Assert.Equal(expectedMsg, actual.Message);
    }
    [Fact]
    public void ThaoTac_Them1PhanTuVaoHangDoiFull_TraVeException()
    {
      int max = 10;
      var queue = new Queue(max);

      for (int i = 0; i < max; i++)
        queue.Enqueue(i);

      var expectedMsg = "Queue is full!";

      Console.WriteLine(queue.Front + " " + queue.Rear);
      var actual = Assert.Throws<InvalidOperationException>(() => queue.Enqueue(69));

      Assert.Equal(expectedMsg, actual.Message);
    }

    [Fact]
    public void ThaoTac_Lay1PhanTuKhoiHangDoiRong_TraVeException()
    {
      //Given
      var queue = new Queue(10);
      var expectedMsg = "Queue is empty!";

      //When
      var actual = Assert.Throws<InvalidOperationException>(() => queue.Dequeue());

      //Then
      Assert.Equal(expectedMsg, actual.Message);
    }
  }
}
