using System.Collections.Generic;
using System;
namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryItem {get; set; }
    public Pastry(int pastryItem)
  {
    PastryItem = pastryItem;
  }
  public int GetPastryPrice()
    {
    
      if (PastryItem <= 2)
      {
        return PastryItem * 2;
      }
      else if (PastryItem % 3 == 0)
      {
        return PastryItem / 3 * 5;
      }
      else if (PastryItem % 3 == 2)
      {
        return (PastryItem - 2) / 3 * 5 + 4;
      }
      else
      {
        return (PastryItem - 1) / 3 * 5 + 2;
      }
    }
  }
}