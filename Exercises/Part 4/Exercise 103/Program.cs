using System;

namespace exercise_103
{
  class Program
  {
    public static void Main(string[] args)
    {
      Agent bond = new Agent("James", "Bond");
      Console.WriteLine(bond);

      Agent bourne = new Agent("Jason", "Bourne");
      Console.WriteLine(bond);
    }
  }
}



