using System.Collections.Generic;
using System;
namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set;}
    public int BreadLoaves {get; set; }
    public Bread(int breadPrice, int breadLoaves)
  {
    BreadPrice = 5;
    BreadLoaves = breadLoaves;
  }

    public int GetBreadPrice()
    {
      int BreadPrice = 5;
      
      if (BreadLoaves == 1)
      {
        return BreadPrice = 5;
      }
      else if (BreadLoaves == 2)
      {
        return BreadPrice = 10;
      }
      else if (BreadLoaves == 3)
      {
        return BreadPrice = 10;
      }
      else
      {
        return BreadLoaves * 5;
      }
      return BreadPrice;
    }
  }
}