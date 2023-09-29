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
      string orderDate = DateTime.Now.ToString("dd/MM/yyyy");
      Order newOrder = new Order(title, desc, price, orderDate);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitleOfOrder_String()
    {
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      float price = 220.50F;
      string orderDate = DateTime.Now.ToString("dd/MM/yyyy");
      Order newOrder = new Order(title, desc, price, orderDate);
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfOrder_Float()
    {
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      float price = 220.50F;
      string orderDate = DateTime.Now.ToString("dd/MM/yyyy");
      Order newOrder = new Order(title, desc, price, orderDate);
      Assert.AreEqual(desc, newOrder.Description);
    }

    [TestMethod]
    public void GetDate_ReturnsDateOfOrder_String()
    {
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      float price = 220.50F;
      string orderDate = DateTime.Now.ToString("dd/MM/yyyy");
      Order newOrder = new Order(title, desc, price, orderDate);

      Assert.AreEqual(desc, newOrder.Date);
    }
  }
}