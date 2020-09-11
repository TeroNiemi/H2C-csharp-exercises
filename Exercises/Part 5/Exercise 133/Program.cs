using System;
using System.Collections.Generic;

namespace exercise_133
{
  class Program
  {
    public static void Main(string[] args)
    {
      Money money = new Money(100, 00);
      Money moreMoney = new Money(500, 50);

      Money combined = money.Plus(moreMoney);

      Console.WriteLine(money);
      Console.WriteLine(moreMoney);
      Console.WriteLine(combined);

      Money lessMoney = moreMoney.Minus(money);

      Console.WriteLine(money);
      Console.WriteLine(moreMoney);
      Console.WriteLine(lessMoney);

      lessMoney = lessMoney.Minus(money);

      Console.WriteLine(money);
      Console.WriteLine(moreMoney);
      Console.WriteLine(lessMoney);

      Console.WriteLine(lessMoney.LessThan(moreMoney));
      Console.WriteLine(lessMoney.LessThan(money));

      lessMoney = lessMoney.Minus(moreMoney);
      Console.WriteLine(lessMoney);
    }
  }
}
