using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.WriteLine("Give the first number!");
     var num1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Give the second number!");
     var num2 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Give the third number!");
     var num3 = Convert.ToInt32(Console.ReadLine());
     int sum = num1 + num2 + num3;
     Console.WriteLine("The sum is " + sum );

    }
  }
}
