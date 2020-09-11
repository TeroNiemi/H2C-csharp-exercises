using System;

// DO NOT TOUCH THIS FILE!
namespace exercise_94
{
  public class Account {

    public double balance { get; set; }
    private string owner;

    public Account(string owner, double balance) {
        this.balance = balance;
        this.owner = owner;
    }

    public void Deposit(double amount) {
        this.balance = this.balance + amount;
    }

    public void Withdrawal(double amount) {
        this.balance = this.balance - amount;
    }

    public override string ToString()
    {
      return this.owner + " balance: " + this.balance;
    }
  }
}
// DO NOT TOUCH THIS FILE!