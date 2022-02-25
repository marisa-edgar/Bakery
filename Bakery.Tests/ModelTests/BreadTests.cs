using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests 
  {
    [TestMethod]
    public void BreadMaker_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1,1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBread_BreadPrice_Int()
    {
      int breadPrice = 5;
      int breadLoaves = 1;
      Bread newBread = new Bread(breadPrice, breadLoaves);
      int inputBread = newBread.BreadPrice;
      Assert.AreEqual(inputBread, breadPrice);
    }

    [TestMethod]
    public void GetBread_BreadPriceForTwoLoaves_Int()
    {
      int breadPrice = 5;
      int breadLoaves = 2;
      Bread newBread = new Bread(breadPrice, breadLoaves);
      int price = newBread.BreadPrice;
      int expectedPrice = 10;
      Assert.AreEqual(expectedPrice, price);
    }
  }
}