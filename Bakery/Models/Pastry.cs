using System.Collections.Generic;
using System;
namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryItem {get; set; }
    public Pastry(int pastryPrice, int pastryItem)
  {
    pastryPrice = 2;
    PastryItem = pastryItem;
  }
  public int GetPastryPrice()
    {
      int PastryPrice = 5;
    
      if (PastryItem == 1)
      {
        return PastryPrice = 2;
      }
      else
      {
        return PastryPrice * 2;
      }
    }
  }
}