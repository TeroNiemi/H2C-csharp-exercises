using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
         Console.WriteLine("Give two numbers");
           int start = Convert.ToInt32(Console.ReadLine());
            int last = Convert.ToInt32(Console.ReadLine());
           
            DivisibleByThreeInRange(int x, int y);
   
    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int x, int y)
    { int beginning = 0;
       int end = 0;

       if (x < y)
            {
            beginning = x;
            end = y;
            }
      else if (x > y)
            {
            beginning = y;
                end = x;
            }
       else if (x == y)
            {
            Console.WriteLine("Beginning and end are same");
            }
       
            
             while (beginning < end)
              {
               if (beginning % 3 == 0){
                
                 beginning++;
            Console.WriteLine(beginning);
                    }
                 }
            
       
    }

  }
}
