using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
       int number = Convert.ToInt32(Console.ReadLine());
       int remainder = number % 2;

        

            if (remainder == 0) {
        Console.WriteLine("It is even.");
        }

            else {
        Console.WriteLine("It is odd.");
        }
        

       Console.ReadKey();
    }
  }
}
