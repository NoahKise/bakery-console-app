using System;
using Bakery.Models;
using System.Threading;

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
      MultiLineAnimation();
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine(@" 
 _______  .-./`) ,---------.          _______      ____    .--.   .--.      .-''-.  .-------.       ____     __  
\  ____  \\ .-.')\          \        \  ____  \  .'  __ `. |  | _/  /     .'_ _   \ |  _ _   \      \   \   /  / 
| |    \ |/ `-' \ `--.  ,---'        | |    \ | /   '  \  \| (`' ) /     / ( ` )   '| ( ' )  |       \  _. /  '  
| |____/ / `-'`'`    |   \           | |____/ / |___|  /  ||(_ ()_)     . (_ o _)  ||(_ o _) /        _( )_ .'   
|   _ _ '. .---.     :_ _:           |   _ _ '.    _.-`   || (_,_)   __ |  (_,_)___|| (_,_).' __  ___(_ o _)'    
|  ( ' )  \|   |     (_I_)           |  ( ' )  \.'   _    ||  |\ \  |  |'  \   .---.|  |\ \  |  ||   |(_,_)'     
| (_{;}_) ||   |    (_(=)_)          | (_{;}_) ||  _( )_  ||  | \ `'   / \  `-'    /|  | \ `'   /|   `-'  /      
|  (_,_)  /|   |     (_I_)           |  (_,_)  /\ (_ o _) /|  |  \    /   \       / |  |  \    /  \      /       
/_______.' '---'     '---'           /_______.'  '.(_,_).' `--'   `'-'     `'-..-'  ''-'   `'-'    `-..-'        
                                                                                                                 ");
      Console.WriteLine("");
      Console.WriteLine("  |--------------------------|");
      Console.WriteLine("  |  Welcome to Bit Bakery!  |");
      Console.WriteLine("  |--------------------------|");
      Console.WriteLine("  |                          |");
      Console.WriteLine("  |  *Baguette: $5 OR 3/$10  |");
      Console.WriteLine("  |                          |");
      Console.WriteLine("  |  *Croissant: $2 OR 4/$6  |");
      Console.WriteLine("  |                          |");
      Console.WriteLine("  | * Secret discounts for * |");
      Console.WriteLine("  |  * Secret quantities! *  |");
      Console.WriteLine("  |                          |");
      Console.WriteLine("  |--------------------------|");
      GetBreadInput();

      static void MultiLineAnimation()
      {
        var counter = 0;
        for (int i = 0; i < 30; i++)
        {
          Console.Clear();
          switch (counter % 4)
          {
            case 0:
              {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("     ╔════╤╤╤╤════╗");
                Console.WriteLine("     ║    │││ \\   ║");
                Console.WriteLine("     ║    │││  O  ║");
                Console.WriteLine("     ║    OOO     ║");
                Console.WriteLine("");
                Console.WriteLine("     Loading...");
                Console.WriteLine("");
                break;
              };
            case 1:
              {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("     ╔════╤╤╤╤════╗");
                Console.WriteLine("     ║    ││││    ║");
                Console.WriteLine("     ║    ││││    ║");
                Console.WriteLine("     ║    OOOO    ║");
                Console.WriteLine("");
                Console.WriteLine("     Loading...");
                Console.WriteLine("");
                break;
              };
            case 2:
              {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("     ╔════╤╤╤╤════╗");
                Console.WriteLine("     ║   / │││    ║");
                Console.WriteLine("     ║  O  │││    ║");
                Console.WriteLine("     ║     OOO    ║");
                Console.WriteLine("");
                Console.WriteLine("         Loading...");
                Console.WriteLine("");
                break;
              };
            case 3:
              {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("     ╔════╤╤╤╤════╗");
                Console.WriteLine("     ║    ││││    ║");
                Console.WriteLine("     ║    ││││    ║");
                Console.WriteLine("     ║    OOOO    ║");
                Console.WriteLine("");
                Console.WriteLine("         Loading...");
                Console.WriteLine("");
                break;
              };
          }
          counter++;
          Thread.Sleep(200);
        }
      }

      static void GetBreadInput()
      {
        Console.WriteLine("");
        Console.WriteLine("How many Baguettes would you like?");
        Console.WriteLine("");
        string breadInputString = Console.ReadLine();
        if (!int.TryParse(breadInputString, out int breadInput))
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Sorry, I don't understand...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          GetBreadInput();
        }
        else if (!int.TryParse(breadInputString, out int breadInputNumber) || breadInputNumber > 1000000)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Oh man, this is embarassing, I only made one million this morning...");
          Console.WriteLine("(Please enter a valid positive intiger below 1000001)");
          Console.ResetColor();
          GetBreadInput();
        }
        else if (!int.TryParse(breadInputString, out int breadInputNum) || breadInputNum < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("I can't exactly sell you a negative amount...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          GetBreadInput();
        }
        else
        {
          breadQuantity = int.Parse(breadInputString);
          breadOrder = new Bread(breadQuantity);
          Console.WriteLine("");
          Console.WriteLine("Okie dokie, coming right up!");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          GetPastryInput();
        }
      }
      static void GetPastryInput()
      {
        Console.WriteLine("And how about some croissants? How many would you like?");
        Console.WriteLine("");
        string pastryInputString = Console.ReadLine();
        if (!int.TryParse(pastryInputString, out int pastryInput))
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Sorry, I don't understand...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          GetPastryInput();
        }
        else if (!int.TryParse(pastryInputString, out int pastryInputNumber) || pastryInputNumber > 1000000)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Oh man, this is embarassing, I only made one million this morning...");
          Console.WriteLine("(Please enter a valid positive intiger below 1000001)");
          Console.ResetColor();
          GetPastryInput();
        }
        else if (!int.TryParse(pastryInputString, out int pastryInputNum) || pastryInputNum < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("I can't exactly sell you a negative amount...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          GetPastryInput();
        }
        else
        {
          pastryQuantity = int.Parse(pastryInputString);
          pastryOrder = new Pastry(pastryQuantity);
          Console.WriteLine("");
          Console.WriteLine("You got it!");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          ConfirmOrEditOrder();
        }
      }

      static void NewOrderOrLeave()
      {
        Console.WriteLine($"Thanks for stopping by Bit Bakery. Would you like to place another order? (y/n)");
        Console.WriteLine("");
        string anotherOrderResponse = Console.ReadLine().ToLower();
        if (anotherOrderResponse == "y")
        {
          Console.WriteLine("");
          Main();
        }
        else if (anotherOrderResponse == "n")
        {
          Console.WriteLine("");
          Console.WriteLine("Ok then, thank you come again!");
          Console.WriteLine("");
          Console.WriteLine("");
          Console.WriteLine("");
          Console.WriteLine(@"
  .-_'''-.       ,-----.        ,-----.     ______      _______      ____     __   .-''-.  .---.  
 '_( )_   \    .'  .-,  '.    .'  .-,  '.  |    _ `''. \  ____  \    \   \   /  /.'_ _   \ \   /  
|(_ o _)|  '  / ,-.|  \ _ \  / ,-.|  \ _ \ | _ | ) _  \| |    \ |     \  _. /  '/ ( ` )   '|   |  
. (_,_)/___| ;  \  '_ /  | :;  \  '_ /  | :|( ''_'  ) || |____/ /      _( )_ .'. (_ o _)  | \ /   
|  |  .-----.|  _`,/ \ _/  ||  _`,/ \ _/  || . (_) `. ||   _ _ '.  ___(_ o _)' |  (_,_)___|  v    
'  \  '-   .': (  '\_/ \   ;: (  '\_/ \   ;|(_    ._) '|  ( ' )  \|   |(_,_)'  '  \   .---. _ _   
 \  `-'`   |  \ `'/  \  ) /  \ `'/  \  ) / |  (_.\.' / | (_{;}_) ||   `-'  /    \  `-'    /(_I_)  
  \        /   '. \_/``'.'    '. \_/``'.'  |       .'  |  (_,_)  / \      /      \       /(_(=)_) 
   `'-...-'      '-----'        '-----'    '-----'`    /_______.'   `-..-'        `'-..-'  (_I_)  
                                                                                                  ");
          Console.WriteLine("");
          Console.WriteLine("");
          Console.WriteLine("");
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Huh, I didn't quite catch that...");
          Console.WriteLine("(Please only enter 'y' or 'n')");
          Console.WriteLine("");
          Console.ResetColor();
          NewOrderOrLeave();
        }
      }

      static void CheckOut()
      {
        breadPrice = breadOrder.PriceBread();
        pastryPrice = pastryOrder.PricePastry();
        Order userOrder = new Order(breadPrice, pastryPrice);
        Console.WriteLine("");
        Console.WriteLine($"Alrighty! {breadOrder.Quantity} baguettes and {pastryOrder.Quantity} croissants comes out to...");
        Thread.Sleep(700);
        Console.WriteLine("...");
        Thread.Sleep(700);
        Console.WriteLine("Hmm...");
        Thread.Sleep(700);
        Console.WriteLine("...");
        Thread.Sleep(700);
        Console.WriteLine("...");
        Thread.Sleep(700);
        Console.WriteLine("...Let's see...");
        Thread.Sleep(700);
        Console.WriteLine("...");
        Thread.Sleep(700);
        Console.WriteLine("...");
        Thread.Sleep(700);
        Console.WriteLine("...Carry the one...");
        Thread.Sleep(700);
        Console.WriteLine("...");
        Thread.Sleep(700);
        Console.WriteLine("...");
        Thread.Sleep(700);
        int orderTotal = userOrder.CalculateTotal();
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        if (orderTotal == 1504 || orderTotal == 860)
        {
          int salePrice = orderTotal / 2;
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine($"***        You've found the secret quantities!        ***");
          Console.ForegroundColor = ConsoleColor.DarkBlue;
          Console.WriteLine($"***       Normally your order would cost ${orderTotal}.00      ***");
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine($"***             But today it is half off!             ***");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine($"***                Sale Price: ${salePrice}.00                ***");
          Console.ResetColor();
          Console.WriteLine("");
          NewOrderOrLeave();
        }
        else
        {
          Console.WriteLine($"${orderTotal}.00 !");
          Console.ResetColor();
          Console.WriteLine("");
          NewOrderOrLeave();
        }
      }

      static void ConfirmBread()
      {
        Console.WriteLine("");
        Console.WriteLine("How many baguettes are we doin today?");
        Console.WriteLine("");
        string bread = Console.ReadLine();
        if (!int.TryParse(bread, out int breadInput))
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Sorry, I don't understand...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          ConfirmBread();
        }
        else if (!int.TryParse(bread, out int breadInputNumber) || breadInputNumber > 1000000)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Oh man, this is embarassing, I only made one million this morning...");
          Console.WriteLine("(Please enter a valid positive intiger below 1000001)");
          Console.ResetColor();
          ConfirmBread();
        }
        else if (!int.TryParse(bread, out int breadInputNum) || breadInputNum < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("I can't exactly sell you a negative amount...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          ConfirmBread();
        }
        else
        {
          breadQuantity = int.Parse(bread);
          breadOrder = new Bread(breadQuantity);
          Console.WriteLine("");
          Console.WriteLine("Okie dokie, coming right up!");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          ConfirmPastry();
        }
      }

      static void ConfirmPastry()
      {
        Console.WriteLine("");
        Console.WriteLine("And how many croissants?");
        Console.WriteLine("");
        string pastry = Console.ReadLine();
        if (!int.TryParse(pastry, out int pastryInput))
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Sorry, I don't understand...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          ConfirmPastry();
        }
        else if (!int.TryParse(pastry, out int pastryInputNumber) || pastryInputNumber > 1000000)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Oh man, this is embarassing, I only made one million this morning...");
          Console.WriteLine("(Please enter a valid positive intiger below 1000001)");
          Console.ResetColor();
          ConfirmPastry();
        }
        else if (!int.TryParse(pastry, out int pastryInputNum) || pastryInputNum < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("I can't exactly sell you a negative amount...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          ConfirmPastry();
        }
        else
        {
          pastryQuantity = int.Parse(pastry);
          pastryOrder = new Pastry(pastryQuantity);
          Console.WriteLine("");
          Console.WriteLine("You got it!");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          ConfirmOrEditOrder();
        }
      }

      static void ConfirmOrEditOrder()
      {
        Order userOrder = new Order(breadPrice, pastryPrice);
        Console.WriteLine("");
        Console.WriteLine($"So, by my count that's {breadOrder.Quantity} baguettes and {pastryOrder.Quantity} croissants.");
        Console.WriteLine("Would you like to adjust your order? (y/n)");
        Console.WriteLine("");
        string confirmResponse = Console.ReadLine().ToLower();
        if (confirmResponse == "y")
        {
          Console.WriteLine("");
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
          Console.WriteLine("");
          Console.WriteLine("Huh, I didn't quite catch that...");
          Console.WriteLine("(Please only enter 'y' or 'n')");
          Console.ResetColor();
          ConfirmOrEditOrder();
        }
      }
    }
  }
}