using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Bread");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitleOfOrder_String()
    {
      string title = "Bread";
      Order newOrder = new Order(title);
      Assert.AreEqual(title, newOrder.Title);
    }
  }
}