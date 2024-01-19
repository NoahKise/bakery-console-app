using System;

namespace Bakery.Models
{
  public class Bread
  {
    public static int PriceBread(int inputNumber)
    {
      int freeLoaves = (int)Math.Floor((double)inputNumber / 3);
      int chargedLoaves = inputNumber - freeLoaves;
      int breadPrice = chargedLoaves * 5;
      return breadPrice;
    }
  }
}