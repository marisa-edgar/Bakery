using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Program
  {
    public static void Main()
    {
      Console.WriteLine("############################");
      Console.WriteLine("Welcome to Pierres Bakery, where we only sell random selected breads and pastries. If you want to select your own bread or pastry go somewhere else, we don't have time for that");
      Start();
      static void Start()
      {
        Console.WriteLine("########################");
        Console.WriteLine("Would you like randomly selected Bread(Y/N)");
        string bread = Console.ReadLine().ToUpper();
        if (bread == "Y")
        {
          Console.WriteLine("########################");
          Console.WriteLine("How many Breads loaves would you like?");
          string BreadPurchase = Console.ReadLine();
          int BreadAmount = int.Parse(BreadPurchase);
          Console.WriteLine("Your Bread has been added to your cart");
          Console.WriteLine("###########################");
          Console.WriteLine("How many Pastries would you like?");
          string PastryPurchase = Console.ReadLine();
          int PastryAmount = int.Parse(PastryPurchase);
          Console.WriteLine("Your Pastries has been added to your cart");
          Console.WriteLine("###########################");
          Bread newBread = new Bread(5, BreadLoaves);
          Pastry newPastry = new Pastry(2, PastryItems);
          Console.WriteLine("###########################");
          Console.WriteLine($"Here is your total: ${newBread.GetBreadPrice() + newPastry.GetPastryPrice()} +.00");
          End();
        }
        else if (check == "N")
        {
          Console.WriteLine("#############################");
          Console.WriteLine("Get out of here and stop wasting my time");
        }
        else
      {
        Console.WriteLine("####################################################");
        Console.WriteLine("Okay mumbles speak up. Please type Y or N.");
        Start();
      }
      static void End()
      {
        Console.WriteLine("################################################");
        Console.WriteLine("Did you forget something? (Y/N)");
        string another = Console.ReadLine().ToUpper();
        if (another == "Y")
        {
          Start();
        }
        else if (another == "N")
        {
        Console.WriteLine("##############################################");
        Console.WriteLine("Okay Thanks Bye!");
        Console.WriteLine("###############################################");
        }
        else
        {
          Console.WriteLine("##############################################");
          Console.WriteLine("Okay mumbles speak up. Please type Y or N.");
          End();
        }
        }
      }
    }
  }
}
