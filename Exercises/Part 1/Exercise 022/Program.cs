using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the third number!");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average is " + ((double)( num1 + num2 + num3 ) /3));

    }
  }
}
