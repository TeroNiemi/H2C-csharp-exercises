using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:
    public static int Smallest(int number1, int number2)
        {
            int greater = 0;
            int Smallest = 0;
            if (number1 < number2)
            {
               Smallest = number1;
                greater = number2;
            }else if (number1 > number2)
            {
                Smallest = number2;
                 greater = number1;
            } else 
            {
                Console.WriteLine("same");
            }
            return Smallest;
        }
    
  }
}
