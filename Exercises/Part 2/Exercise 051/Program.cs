using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintUntilNumber(5);

    }

    // Write your method here:
     public static void PrintUntilNumber(int number)
      {        int a = 1;
          
        Console.WriteLine("Give number");
        
            while (number < 5)
            {
                number = Convert.ToInt32(Console.ReadLine());
                   
                Console.WriteLine(number);
                  a++;
     }       }
          
  }
}
