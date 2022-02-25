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
  }
}