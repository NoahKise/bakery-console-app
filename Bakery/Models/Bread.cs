using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public Bread()
    {
      Quantity = 0;
    }
    public Bread(int quantity)
    {
      Quantity = quantity;
    }
    public int PriceBread()
    {
      int freeLoaves = (int)Math.Floor((double)Quantity / 3);
      int chargedLoaves = Quantity - freeLoaves;
      int breadPrice = chargedLoaves * 5;
      return breadPrice;
    }
  }
}