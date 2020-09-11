using System;

namespace exercise_111

{
  // DO NOT TOUCH THE CODE IN HERE
  public class PersonalInformation
  {

    public string firstName { get; set; }
    public string lastName { get; set; }
    public string identificationNumber { get; set; }

    public PersonalInformation(string firstName, string lastName, string identificationNumber)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.identificationNumber = identificationNumber;
    }

    public override string ToString()
    {
      return this.lastName + ", " + this.firstName + " (" + this.identificationNumber + ")";
    }
  }
}