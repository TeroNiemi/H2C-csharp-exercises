using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            Console.Write("I will tell a story, but I need some information.\nWhat is your name?");
            string characterName = Console.ReadLine();

            Console.Write("What is your profession?");
            string characterProfession = Console.ReadLine();


            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a "+ characterProfession + " called " + characterName);
            Console.WriteLine("On her way to work, " + characterName + " often pondered what being " + characterProfession + " meant to them.");
            Console.WriteLine("When you work as a " + characterProfession + " you meet interesting people.");          
            Console.WriteLine(""+ characterName + " enjoys their work as " + characterProfession);

           Console.ReadKey();



        }
    }
}
