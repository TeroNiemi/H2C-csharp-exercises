using System;

namespace exercise_102
{
  class Program
  {
    public static void Main(string[] args)
    {
      Gauge g = new Gauge();

      while (!g.Full())
      {
        Console.WriteLine("Not full! Value: " + g.value);
        g.Increase();
      }

      Console.WriteLine("Full! Value: " + g.value);
      g.Decrease();
      Console.WriteLine("Not full! Value: " + g.value);
    }
  }
}



