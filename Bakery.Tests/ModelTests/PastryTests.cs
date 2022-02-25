using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests 
  {
    [TestMethod]
    public void PastryMaker_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1,1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastry_PastryPrice_Int()
    {
      int pastryPrice = 2;
      int pastryItem = 1;
      Pastry newPastry = new Pastry(pastryPrice, pastryItem);
      int inputPastry = newPastry.GetPastryPrice();
      Assert.AreEqual(inputPastry, pastryPrice);
    }

    [TestMethod]
    public void GetPastry_PastryPriceForThreeItems_Int()
    {
      int pastryPrice = 5;
      int pastryItem = 3;
      Pastry newPastry = new Pastry(pastryPrice, pastryItem);
      int inputPastry = newPastry.GetPastryPrice();
      int expectedPrice = 5;
      Assert.AreEqual(inputPastry, pastryPrice);
    }

    [TestMethod]
    public void GetPastry_PastryPriceForFiveItems_Int()
    {
      int pastryPrice = 7;
      int pastryItem = 5;
      Pastry newPastry = new Pastry(pastryPrice, pastryItem);
      int inputPastry = newPastry.GetPastryPrice();
      int expectedPrice = 7;
      Assert.AreEqual(inputPastry, pastryPrice);
    }
  }
}