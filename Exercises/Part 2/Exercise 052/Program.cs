using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintFromNumberToOne(5);

    }

    // Write your method here:
     public static void PrintFromNumberToOne(int number)
    {
        Console.WriteLine("Give number ot times");
          for (int i= 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

     }
  }
}
