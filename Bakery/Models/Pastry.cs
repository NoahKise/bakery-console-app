using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public static int PricePastry(int inputNumber)
    {
      int freePastries = (int)Math.Floor((double)inputNumber / 4);
      int chargedPastries = inputNumber - freePastries;
      int pastryPrice = chargedPastries * 2;
      return pastryPrice;
    }
  }
}