using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
    public static int Greatest(int a, int b, int c) 
    { int greatest =0;
      
       if (a > b  && a > c)
        {
            greatest = a;
       }
       else if (b >a && b > c)
       {
         greatest = b;
       }
       else if (c >a && c > b)
       {
         greatest = c;
       }
       return greatest;
    }
        

  }
}
