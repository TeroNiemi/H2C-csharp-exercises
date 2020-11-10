using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Your speed:");
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed > 120)
            {
                Console.WriteLine("Speeding!");
            }
    }
  }
}
