namespace Bakery.Models
{
  public class Order
  {
    public static int CalculateTotal(int breadPrice, int pastryPrice)
    {
      int totalPrice = breadPrice + pastryPrice;
      return totalPrice;
    }
  }
}