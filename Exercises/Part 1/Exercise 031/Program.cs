using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            {
            Console.Write("It is even. ");
            }

            else
            {
            Console.Write("It is odd. ");

            }
    }
  }
}
