using System.Collections.Generic;
using System;
namespace Bakery.Models
{
  public class Bread
  { public int BreadLoaves {get; set; }
    public Bread (int breadLoaves)
  {
    BreadLoaves = breadLoaves;
  }

    public int GetBreadPrice()
    {  
      if (BreadLoaves <= 2)
      {
        return BreadLoaves * 5;
      }
      else if (BreadLoaves % 3 == 0)
      {
        return BreadLoaves / 3 * 10;
      }
      else if (BreadLoaves % 3 == 2)
      {
        return (BreadLoaves - 2) / 3 * 10 + 10;
      }
      else
      {
        return (BreadLoaves - 1)/ 3 * 10 + 5;
      }
    }
  }
}