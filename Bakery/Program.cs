using System;
using Bakery.Models;

namespace Bakery
{

  class Program
  {
    private static int breadQuantity;
    private static int breadPrice;
    private static int pastryQuantity;

    private static int pastryPrice;
    static void Main()
    {
      Console.WriteLine("Welcome to the bakery");
      GetBreadInput();

      static void GetBreadInput()
      {
        Console.WriteLine("Enter bread amount");
        string breadInputString = Console.ReadLine();
        if (!int.TryParse(breadInputString, out int breadInput) || breadInput < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Please enter a valid positive intiger");
          Console.ResetColor();
          GetBreadInput();
        }
        else
        {
          breadQuantity = int.Parse(breadInputString);
          breadPrice = Bread.PriceBread(breadQuantity);
          GetPastryInput();
        }
      }
      static void GetPastryInput()
      {
        Console.WriteLine("Enter pastry amount");
        string pastryInputString = Console.ReadLine();
        if (!int.TryParse(pastryInputString, out int pastryInput) || pastryInput < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Please enter a valid positive intiger");
          Console.ResetColor();
          GetPastryInput();
        }
        else
        {
          pastryQuantity = int.Parse(pastryInputString);
          pastryPrice = Pastry.PricePastry(pastryQuantity);
          CheckOut();
        }
      }

      static void CheckOut()
      {
        Order userOrder = new Order(breadPrice, pastryPrice);
        Console.WriteLine($"You have ordered {breadQuantity} loaves of bread and {pastryQuantity} pastries.");
        int orderTotal = userOrder.CalculateTotal();
        Console.WriteLine($"Your total is ${orderTotal}");
      }
    }
  }
}