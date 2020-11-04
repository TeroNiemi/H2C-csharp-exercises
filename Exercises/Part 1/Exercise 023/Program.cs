using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

       Console.WriteLine("Give the first number!");
       int num1 = Convert.ToInt32(Console.ReadLine());
      
       Console.WriteLine("Give the second number!");
       int num2 = Convert.ToInt32(Console.ReadLine());

      int num3 = num1 + num2;
      int num4 = num1 - num2;
      int num5 = num1 * num2;
      int num6 = num1 / num2;

       Console.WriteLine("{0} + {1} = {2}", num1, num2, num3);
       Console.WriteLine("{0} - {1} = {2}", num1, num2, num4);
       Console.WriteLine("{0} - {1} = {2}", num1, num2, num5);
       Console.WriteLine("{0} - {1} = {2}", num1, num2, num6);
       

     Console.ReadKey();

    }
  }
}
