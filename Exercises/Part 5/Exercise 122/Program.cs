using System;

namespace exercise_122
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Product tapeMeasure = new Product("Tape measure");
      Product plaster = new Product("Plaster", "home improvement section");
      Product tyre = new Product("Tyre", 5);

      Console.WriteLine(tapeMeasure);
      Console.WriteLine(plaster);
      Console.WriteLine(tyre);
    }
  }
}
