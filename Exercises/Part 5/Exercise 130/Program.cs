using System;
using System.Collections.Generic;

namespace exercise_130
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<Book> books = new List<Book>();

      while (true)
      {
        Console.WriteLine("Name (empty will stop):");
        string name = Console.ReadLine();
        if (name == "")
        {
          break;
        }

        Console.WriteLine("Publication year:");
        int publicationYear = Convert.ToInt32(Console.ReadLine());
        Book book = new Book(name, publicationYear);

        // BEGIN SOLUTION
        // Add unique books to the list.
        // Remember to print
        // "The book is already on the list. Let's not add the same book again."
        // If the list Contains the book




        // END SOLUTION
      }

      // Don't alter the line below!
      Console.WriteLine("Thank you! Books added: " + books.Count);

    }

  }
}
