using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How old are you?");
       int number = Convert.ToInt32(Console.ReadLine());
            

         if (number >=  18) {
        Console.WriteLine("You are an adult!");
         }
        else if (number < 18) {
        Console.WriteLine("You are under age!");
        }
      Console.ReadKey();


    }
  }
}
