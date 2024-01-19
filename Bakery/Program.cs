using System;

class Program
{
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
        int breadQuantity = int.Parse(breadInputString);
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
        int pastryQuantity = int.Parse(pastryInputString);
      }
    }
  }
}