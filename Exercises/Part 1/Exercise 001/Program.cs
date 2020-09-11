using System;

namespace exercise_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
        }
         public void TestExercise01()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Program.Main(null);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.AreEqual( "Hello World!\n", sw.ToString().Replace("\r\n","\n"), "Check your code! The test requires exact match!");
            }
        }
    }
}
