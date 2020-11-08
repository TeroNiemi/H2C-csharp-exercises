using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      int neg = 0;
       while (true) 
       {
          Console.WriteLine("Input an integer, 0 quits");
          int number = Convert.ToInt32(Console.ReadLine());
             if (number == 0)
            {
                break;
            }
             else if (number< 0)
             {
                neg++;
             }
             
             Console.WriteLine("Total amount of negative numbers: " + neg + "." );
       }



    }
  }
}
