using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
            string abc = "Potato";
            string xyz = "Potato"; 

            Console.WriteLine("Give the first string:");
            abc = Console.ReadLine();

            Console.WriteLine("Give the second string:");
            xyz = Console.ReadLine();

           if (abc == xyz){
            Console.WriteLine("Echo!");
            }

           else {
            Console.WriteLine("Nope!");
            }
        

            Console.ReadKey();

            
    }
  }
}
