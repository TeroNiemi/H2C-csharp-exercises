using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      int sum = 0;
      int attempts = 0;
         while (true)
         {
            Console.WriteLine("Input an integer, 0 quits");
            int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                break;
                }
                else
                {
                    attempts++;
                    sum = sum + number;

                }
                  Console.WriteLine("Total amount of attempts is: " + attempts); 
                   Console.WriteLine("Total sum of numbers : " + sum);
         }

    }
  }
}
