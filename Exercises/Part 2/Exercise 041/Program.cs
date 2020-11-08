using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

            Console.WriteLine("Give a number and calculate the second power of the given number");
            int first = Convert.ToInt32(Console.ReadLine());
           
            
            int product = first * first;
            Console.WriteLine("The product of " + first + " and " + first + " is " + product);

            Console.ReadKey();
      
    }
  }
}
