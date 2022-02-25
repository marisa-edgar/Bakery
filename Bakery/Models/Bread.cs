using System.Collections.Generic;
using System;
namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; }
    public int BreadLoaves {get;}
    public Bread(int breadPrice, int breadLoaves)
  {
    BreadPrice = 5;
    BreadLoaves = breadLoaves;
  }
    
  }
}