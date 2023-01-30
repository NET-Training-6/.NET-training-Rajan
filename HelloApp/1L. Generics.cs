class Generic
{
  public void Print<T>(T message)
  {
    Console.WriteLine(message);
  }

  public void Test()
  {
    Print<string>("Santosh Bro");
    Print<byte>(34);
    Print<bool>(true);
    Print<double>(70.677);
    Print<DateTime>(DateTime.Now);
    Print<Animal>(new Animal());
  }

}