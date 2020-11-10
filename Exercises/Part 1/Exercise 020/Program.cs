using System;
using System.Xml.Linq;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.WriteLine("Give the first number!");
     int num1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Give the second number!");
     int num2 = Convert.ToInt32(Console.ReadLine());
     int value = num1 * num2;
     Console.Write(num1 + " * ");     
     Console.Write(num2);
     Console.Write(" = " + value + "\n");

    }
  }
}
