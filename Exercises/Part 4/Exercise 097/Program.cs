using System;

namespace exercise_97
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Create Whistle.cs and follow the instructions.
      // You can test your Whistle class with these.
      Whistle duckWhistle = new Whistle("Kvaak");
      Whistle roosterWhistle = new Whistle("Peef");

      duckWhistle.Sound();
      roosterWhistle.Sound();
      duckWhistle.Sound();

    }
  }
}



