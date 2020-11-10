using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int minus = num1 - num2;
            int multi = num1 * num2;
            double divi = (double)num1 / (double)num2;
            Console.WriteLine( num1 + " + " + num2 + " = " + sum);
            Console.WriteLine( num1 + " - " + num2 + " = " + minus);
            Console.WriteLine( num1 + " * " + num2 + " = " + multi);
            Console.WriteLine( num1 + " / " + num2 + " = " + divi);


    }
  }
}
