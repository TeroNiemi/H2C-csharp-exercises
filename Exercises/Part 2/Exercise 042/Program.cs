using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

          
            Console.WriteLine("Give two numbers and calculate the square root of the numbers");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int sum = first + second;
            double squareRoot = Math.Sqrt(sum);
            Console.WriteLine("The sum of " + first + " and " + second + " is " + sum);
            Console.WriteLine("The squareroot of is:" + squareRoot);
            
          
            
            
            
            Console.ReadKey();
    }
  }
}
