using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give the first string: ");
            string first = Console.ReadLine();
            Console.WriteLine("Give the second string: ");
            string second = Console.ReadLine();
            if (first == second)
            {
            Console.WriteLine("Echo");
            }

            else
            {
            Console.WriteLine("Nope");
            }
    }
  }
}
