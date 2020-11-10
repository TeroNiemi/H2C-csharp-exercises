using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average is " + ((double)( num1 + num2) /2));

    }
  }
}
