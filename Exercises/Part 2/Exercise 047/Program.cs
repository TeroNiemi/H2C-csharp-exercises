using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
       
            Console.WriteLine("Please give an integer");
            int start = 1;
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= end; i++) 
            {
            Console.WriteLine("Value of i: {0}", i);
            }

            // Write your code here:

            Console.WriteLine("Please give end integer");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give start integer");
            int start = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
            Console.WriteLine(i);
            }


            Console.ReadKey();



          
             
            
    }
  }
}
