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
    
      if (PastryItem <= 2)
      {
        return PastryPrice * 2;
      }
      else if (PastryItem % 3 == 0)
      {
        return PastryPrice / 3 * 5;
      }
      else if (PastryItem % 3 == 2)
      {
        return (PastryPrice - 2) / 3 * 5 + 4;
      }
      else
      {
        return (PastryPrice - 1) / 3 * 5 + 2;
      }
    }
  }
}