using System;
using System.Collections.Generic;

namespace exercise_136
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE CODE IN HERE
      Person ada = new Person("Ada Lovelace");
      Person jack = new Person("Jack The Ripper");
      Person mike = new Person("Mike The Incredible Magic Mouse");

      Console.WriteLine(ada + " has " + ada.HowManyNames() + " names.");
      Console.WriteLine(jack + " has " + jack.HowManyNames() + " names.");
      Console.WriteLine(mike + " has " + mike.HowManyNames() + " names.");
    }
  }
}