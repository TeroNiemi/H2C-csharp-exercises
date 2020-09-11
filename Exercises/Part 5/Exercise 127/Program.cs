using System;

namespace exercise_127
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Try your code here, if you want
      Pet lucy = new Pet("Lucy", "golden retriever");
      Person leo = new Person("Leo", lucy);
      Console.WriteLine(leo);

      Person mike = new Person("Mike");
      Console.WriteLine(mike);
      
      Person lilo = new Person();
      Console.WriteLine(lilo);
    }

  }
}
