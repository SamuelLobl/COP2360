using system;

public class Alcohol
{
  public decimal Cost;
  public int Age;
  public Alcohol (decimal cost) => Cost = cost;
  public Alcohol (decimal cost, int age) : this (cost) => Age = age;
}

public class Wine : Alcohol
{
    public bool Grapeflavored;

    public Wine(decimal cost, int age) : base(cost, age)
    {
        this.Grapeflavored = true;
    }
}

