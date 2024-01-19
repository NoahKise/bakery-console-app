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
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|  Welcome to Bit Bakery!  |");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|                          |");
      Console.WriteLine("|  *Baguette: $5 OR 3/$10  |");
      Console.WriteLine("|                          |");
      Console.WriteLine("|  *Croissant: $2 OR 4/$6  |");
      Console.WriteLine("|                          |");
      Console.WriteLine("|--------------------------|");
      GetBreadInput();

      static void GetBreadInput()
      {
        Console.WriteLine("");
        Console.WriteLine("How many Baguettes would you like?");
        Console.WriteLine("");
        string breadInputString = Console.ReadLine();
        if (!int.TryParse(breadInputString, out int breadInput) || breadInput < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Sorry, I don't understand...");
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
        if (!int.TryParse(pastryInputString, out int pastryInput) || pastryInput < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Sorry, I don't understand...");
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
          Console.WriteLine("Okay!");
          GetBreadInput();
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
        Console.WriteLine($"${orderTotal}.00!");
        Console.ResetColor();
        Console.WriteLine("");
        NewOrderOrLeave();
      }

      static void ConfirmBread()
      {
        Console.WriteLine("");
        Console.WriteLine("How many baguettes are we doin today?");
        Console.WriteLine("");
        string bread = Console.ReadLine();
        if (!int.TryParse(bread, out int breadInput) || breadInput < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Sorry, I don't understand...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          ConfirmBread();
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("Okie dokie, coming right up!");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          breadOrder.Quantity = int.Parse(bread);
          ConfirmPastry();
        }
      }

      static void ConfirmPastry()
      {
        Console.WriteLine("");
        Console.WriteLine("And how many croissants?");
        Console.WriteLine("");
        string pastry = Console.ReadLine();
        if (!int.TryParse(pastry, out int pastryInput) || pastryInput < 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("");
          Console.WriteLine("Sorry, I don't understand...");
          Console.WriteLine("(Please enter a valid positive intiger)");
          Console.ResetColor();
          ConfirmPastry();
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("You got it!");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          Console.WriteLine("...");
          Thread.Sleep(700);
          pastryOrder.Quantity = int.Parse(pastry);
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