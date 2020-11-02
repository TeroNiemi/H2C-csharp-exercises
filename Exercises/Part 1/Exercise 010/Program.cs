using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.\n" +
            "Give a name for main character:");
            string main = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string profession = Console.ReadLine();
            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a " + profession + " called " + main);
            Console.WriteLine("On her way to work, " + main + " often pondered what being " + profession + " meant to them.");
            Console.WriteLine("When you work as a " + profession + " you meet interesting people.");
            Console.WriteLine( main + " enjoys their work as " + profession + ", The end.");

        }
    }
}
