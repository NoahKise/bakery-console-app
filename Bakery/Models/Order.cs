namespace Bakery.Models
{
  public class Order
  {
    public int BreadPrice { get; set;}
    public int PastryPrice { get; set;}
    public Order(int breadPrice, int pastryPrice)
    {
      BreadPrice = breadPrice;
      PastryPrice = pastryPrice;
    }
    public static int CalculateTotal(int breadPrice, int pastryPrice)
    {
      int totalPrice = breadPrice + pastryPrice;
      return totalPrice;
    }
  }
}