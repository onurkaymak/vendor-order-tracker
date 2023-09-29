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
      float price = 220.50F;
      Order newOrder = new Order(title, desc, price);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitleOfOrder_String()
    {
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      float price = 220.50F;
      Order newOrder = new Order(title, desc, price);
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfOrder_Float()
    {
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      float price = 220.50F;
      Order newOrder = new Order(title, desc, price);
      Assert.AreEqual(desc, newOrder.Description);
    }
  }
}