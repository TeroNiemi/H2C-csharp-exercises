using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {

       while (true)
       {
        Console.WriteLine("Give an integer and calculate");
        int first = Convert.ToInt32(Console.ReadLine());
        int second = -Math.Abs(1);
       
         if (first > 0)
         {
           
            Console.WriteLine("The number is : " + first);
          }
          if (first < 0)
          {
              int product = first * second;
            Console.WriteLine("The product of " + first + " and " + second + " is " + product);
          }
          else if (first == 0)
                {
                break;
                }
       } 
           
    }

  }
}
