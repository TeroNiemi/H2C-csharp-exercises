using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Please give an integer");
           int num = Convert.ToInt32(Console.ReadLine());
            while(num<6)
            {
                Console.WriteLine(num);
                num++;
            }

    }
  }
}
