using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {

    public void Dispose()
    {
      Bread.ClearAll();
    }

//   [TestClass]
//   public class BreadTests
//   {
//     [TestMethod]
//     public void BreadConstructor_CreatesInstanceOfBread_Bread()
//     {
//       string newBread = new Bread("1");
//       Assert.AreEqual(typeof(Bread), newBread.GetType());
//     }

  }
}