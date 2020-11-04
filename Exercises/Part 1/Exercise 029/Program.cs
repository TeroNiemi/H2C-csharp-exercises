using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
    Console.WriteLine("Give the first number!");
       int num1 = Convert.ToInt32(Console.ReadLine());
            
    Console.WriteLine("Give the second number!");
       int num2 = Convert.ToInt32(Console.ReadLine());

         if (num1 > num2) {
        Console.WriteLine("The larger number is:" + num1);
         }
        else if (num1 < num2) {
        Console.WriteLine("The larger number is:" + num2);
        }
      Console.ReadKey();

    }
  }
}
