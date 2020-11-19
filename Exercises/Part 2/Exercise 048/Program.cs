using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int even = 0;
       int odd = 0; 
      int remainder;
      double avrg = 0;
      int sum = 0;
       int attempt = 0;
      Console.WriteLine("Please give numbers");
        while (true) 
        {       
                
             int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                     Console.WriteLine("Thx! Bye!");
                  
                    break;
                }
                    attempt++;
                    sum += input;  
                    avrg= sum/attempt;
                remainder = input % 2;
                if(remainder== 0)
                {       
                    even +=1;
                   odd += 1;
                }
        }  
             
             Console.WriteLine("Total sum of numbers is : " + sum);
             Console.WriteLine("Total sum of attempt is : " + attempt);
            Console.WriteLine("The average of numbers is : " + avrg);
            Console.WriteLine("Total amount of even numbers is : " + even);
            Console.WriteLine("Total amount of odd numbers is : " + odd);
            
    }
       
  }
}
