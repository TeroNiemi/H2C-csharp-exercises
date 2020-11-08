using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
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
             
            }
             Console.WriteLine("Total amount of numbers: " + attempts + "." );      
       }    
            
           
      
            

      

    }
  }
}
