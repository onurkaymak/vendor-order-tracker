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
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      Order newOrder = new Order(title, desc);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitleOfOrder_String()
    {
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      Order newOrder = new Order(title, desc);
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void GetDesc_ReturnsDescOfOrder_String()
    {
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      Order newOrder = new Order(title, desc);
      Assert.AreEqual(desc, newOrder.Description);
    }
  }
}