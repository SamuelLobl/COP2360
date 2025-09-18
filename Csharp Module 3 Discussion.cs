using system;

public class Wine
{
  public decimal Price;
  public int Year;
  public Wine (decimal price) => Price = price;
  public Wine (decimal price, int year) : this (price) => Year = year;
}
