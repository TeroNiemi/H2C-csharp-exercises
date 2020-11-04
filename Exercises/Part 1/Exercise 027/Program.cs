using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
       int number = Convert.ToInt32(Console.ReadLine());
            

        if (number > 0)
       {
        Console.WriteLine("It is positive");
        }
        else if (number < 0)
       {
       Console.WriteLine("It is not positive");
        }
      Console.ReadKey();


    }
  }
}
