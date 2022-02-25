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
      Bread newBread = new Bread(breadPrice, breadLoaves);
      int breadPrice = 5;
      int breadLoaves = 1;
      int inputBread = newBread.BreadPrice;
      Assert.AreEqual(inputBread, breadPrice);
    }
  }
}