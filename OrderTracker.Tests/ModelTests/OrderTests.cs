using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

      Assert.AreEqual(orderDate, newOrder.Date);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      float price = 220.50F;
      string orderDate = DateTime.Now.ToString("dd/MM/yyyy");
      Order newOrder = new Order(title, desc, price, orderDate);

      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsSelectedOrder_Order()
    {
      string title = "Suzie's Cafe";
      string desc = "20 loaves of bread.";
      float price = 220.50F;
      string orderDate = DateTime.Now.ToString("dd/MM/yyyy");
      Order newOrder = new Order(title, desc, price, orderDate);

      string title2 = "test bakery";
      string desc2 = "test";
      float price2 = 120.50F;
      string orderDate2 = DateTime.Now.ToString("dd/MM/yyyy");
      Order newOrder2 = new Order(title2, desc2, price2, orderDate2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}