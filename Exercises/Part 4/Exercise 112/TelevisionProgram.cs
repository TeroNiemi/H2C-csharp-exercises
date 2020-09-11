using System;

namespace exercise_112

{
  // DO NOT TOUCH THE CODE IN HERE
  public class TelevisionProgram
  {

    public string name { get; set; }
    public int duration { get; set; }

    public TelevisionProgram(string name, int duration)
    {
      this.name = name;
      this.duration = duration;
    }

    public bool IsAwesome()
    {
      return this.name.Contains("MasterChef");
    }

    public override string ToString()
    {
      return this.name + ", " + this.duration + " minutes";
    }
  }
}