using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set;}
    public Pastry()
    {
      Quantity = 0;
    }
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
    public int PricePastry()
    {
      int freePastries = (int)Math.Floor((double)Quantity / 4);
      int chargedPastries = Quantity - freePastries;
      int pastryPrice = chargedPastries * 2;
      return pastryPrice;
    }
  }
}