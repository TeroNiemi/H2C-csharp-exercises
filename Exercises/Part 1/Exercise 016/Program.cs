using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {
     Console.Write("How many days? ");
     int  num1 = Convert.ToInt32(Console.ReadLine());
     int result = num1* 24 * 60 * 60;
     Console.WriteLine( result );

    }
  }
}
