using System;

namespace exercise_107
{
  class Program
  {
    public static void Main(string[] args)
    {
      PaymentCard card = new PaymentCard(50);
      Console.WriteLine(card);

      card.EatLunch();
      Console.WriteLine(card);

      card.DrinkCoffee();
      Console.WriteLine(card);
    }
  }
}




