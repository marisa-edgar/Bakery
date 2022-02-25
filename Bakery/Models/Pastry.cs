using System.Collections.Generic;
using System;
namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; }
    public int PastryItem {get;}
    public Pastry(int pastryPrice, int pastryItem)
  {
    pastryPrice = 2;
    PastryItem = pastryItem;
  }
    
  }
}