namespace exercise_128
{

  using System;
  public class Apartment
  {

    private int rooms;
    private int squares;
    private int pricePerSquare;

    public Apartment(int rooms, int squares, int pricePerSquare)
    {
      this.rooms = rooms;
      this.squares = squares;
      this.pricePerSquare = pricePerSquare;
    }

    public bool LargerThan(Apartment compared)
    {
      return false;
    }

    private int Price()
    {
      return 0;
    }

    public int PriceDifference(Apartment compared)
    {
      // Math.Abs returns the absolute value
      return 0;
    }

    public bool MoreExpensiveThan(Apartment compared)
    {
      return false;
    }
  }

}
