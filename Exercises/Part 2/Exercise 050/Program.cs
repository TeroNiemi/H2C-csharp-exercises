using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
          
      // Call your method here:
       PrintPhrase();
        
           
                

    }

    // Write your method here:
     public static void PrintPhrase (int notimes)
     {
         int a = 0;  
        Console.WriteLine("How many times to print?");
           int notimes = Convert.ToInt32(Console.ReadLine());
             while (a < notimes)
            {
                 Console.WriteLine("In a hole in the ground there lived a method");
                a++;
            }
       
      
      }  
     
     
      
        
    
  }
}
