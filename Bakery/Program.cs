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
    private static Bread breadOrder = null;
    private static Pastry pastryOrder = null;
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
          breadOrder = new Bread(breadQuantity);
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
          pastryOrder = new Pastry(pastryQuantity);
          ConfirmOrEditOrder();
        }
      }

      static void NewOrderOrLeave()
      {
        Console.WriteLine($"Thank you for shopping with us.  Would you like to place another order? (y/n)");
        string anotherOrderResponse = Console.ReadLine().ToLower();
        if (anotherOrderResponse == "y")
        {
          Console.WriteLine("What else can we get for ya?");
          GetBreadInput();
        }
        else if (anotherOrderResponse == "n")
        {
          Console.WriteLine("Ok then, thank you come again!");
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Please only enter 'y' or 'n'.");
          Console.ResetColor();
          NewOrderOrLeave();
        }
      }

      static void CheckOut()
      {
        breadPrice = breadOrder.PriceBread();
        pastryPrice = pastryOrder.PricePastry();
        Order userOrder = new Order(breadPrice, pastryPrice);
        Console.WriteLine($"You have ordered {breadOrder.Quantity} loaves of bread and {pastryOrder.Quantity} pastries.");
        int orderTotal = userOrder.CalculateTotal();
        Console.WriteLine($"Your total is ${orderTotal}");
        NewOrderOrLeave();
      }

      static void ConfirmBread()
      {
        Console.WriteLine("Enter new bread amount:");
        string bread = Console.ReadLine();
        if (!int.TryParse(bread, out int breadInput) || breadInput < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Please enter a valid positive intiger");
          Console.ResetColor();
          ConfirmBread();
        }
        else
        {
          breadOrder.Quantity = int.Parse(bread);
          ConfirmPastry();
        }
      }

      static void ConfirmPastry()
      {
        Console.WriteLine("Enter new pastry amount:");
        string pastry = Console.ReadLine();
        if (!int.TryParse(pastry, out int pastryInput) || pastryInput < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Please enter a valid positive intiger");
          Console.ResetColor();
          ConfirmPastry();
        }
        else
        {
          pastryOrder.Quantity = int.Parse(pastry);
          ConfirmOrEditOrder();
        }
      }

      static void ConfirmOrEditOrder()
      {
        Order userOrder = new Order(breadPrice, pastryPrice);
        Console.WriteLine($"You have ordered {breadOrder.Quantity} loaves of bread and {pastryOrder.Quantity} pastries.");
        Console.WriteLine("Would you like to adjust your order? (y/n)");
        string confirmResponse = Console.ReadLine().ToLower();
        if (confirmResponse == "y")
        {
          Console.WriteLine("Let's fix your order then!");
          ConfirmBread();
        }
        else if (confirmResponse == "n")
        {
          CheckOut();
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Please only enter 'y' or 'n'.");
          Console.ResetColor();
          ConfirmOrEditOrder();
        }
      }
    }
  }
}