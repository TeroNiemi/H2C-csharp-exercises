namespace exercise_122
{
  public class Product
  {
    // DO NOT TOUCH THESE VARIABLES
    private string name;
    private string location;
    private int weight;

    // CREATE YOUR CONSTRUCTORS HERE





    // DO NOT TOUCH THIS
    public override string ToString()
    {
      return $"{this.name} ({this.weight} kg) can be found from the {this.location}.";
    }
  }
}