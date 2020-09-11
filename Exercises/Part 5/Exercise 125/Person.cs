namespace exercise_125
{

  // DO NOT TOUCH THIS FILE!
  public class Person
  {
    public string name { get; }
    private int age;
    public int weight { get; set; }
    private int height;

    public Person(string name, int age, int weight, int height)
    {
      this.name = name;
      this.age = age;
      this.weight = weight;
      this.height = height;
    }

    public double BodyMassIndex()
    {
      double heigthPerHundred = this.height / 100.0;
      return this.weight / (heigthPerHundred * heigthPerHundred);
    }

    public void GrowOlder()
    {
      this.age++;
    }

    public override string ToString()
    {
      return "My name is " + this.name + " and I am " + this.age + " years old. My BMI is " + this.BodyMassIndex();
    }

  }
}