using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give your percent [0-100]                  ");
            int percent = Convert.ToInt32(Console.ReadLine());
            if (percent < 0)
            {
            Console.WriteLine("Impossible");
            }

            else if (percent <= 49)
            {
            Console.WriteLine("Fail");
            }

            else if (percent < 59)
            {
            Console.WriteLine("Grade: 1");
            }

            else if (percent < 69)
            {
            Console.WriteLine("Grade: 2");
            }

            else if (percent < 79)
            {
            Console.WriteLine("Grade: 3");
            }

            else if (percent < 89)
            {
            Console.WriteLine("Grade: 4");
            }

            else if (percent <= 100)
            {
            Console.WriteLine("Grade : 5");
            }

            else if (percent > 100)
            {
            Console.WriteLine("Outstanding!");
            }
    }
  }
}