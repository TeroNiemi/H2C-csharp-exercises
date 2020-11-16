using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first number!");
            string numstr1 = Console.ReadLine();
            int num1 = Convert.ToInt32(numstr1);
            Console.WriteLine("Give the second number!");
            string numstr2 = Console.ReadLine();
            int num2 = Convert.ToInt32(numstr2);
            Console.WriteLine("Give the third number!");
            string numstr3 = Console.ReadLine();
            int num3 = Convert.ToInt32(numstr3);
            double average = ( num1 + num2 + num3 ) / 3.0;
            Console.WriteLine("The average is " + average);
    }
  }
}
