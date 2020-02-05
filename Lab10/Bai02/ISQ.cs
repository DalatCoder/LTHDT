namespace Bai02
{
  public interface ISQ
  {
    int Lenght { get; }
    bool IsEmpty { get; }
    void Push(double number);
    double Pop();
    double Top();
  }
}
