using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Test
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "Suzie's Cafe";
      string desc = "Cute small cafe, long term customer.";
      Vendor newVendor = new Vendor(name, desc);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string name = "Suzie's Cafe";
      string desc = "Cute small cafe, long term customer.";
      Vendor newVendor = new Vendor(name, desc);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDesc_ReturnsVendorDescription_String()
    {
      string name = "Suzie's Cafe";
      string desc = "Cute small cafe, long term customer.";
      Vendor newVendor = new Vendor(name, desc);
      string result = newVendor.Description;
      Assert.AreEqual(desc, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Suzie's Cafe";
      string desc = "Cute small cafe, long term customer.";
      Vendor newVendor = new Vendor(name, desc);

      int result = newVendor.Id;
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Suzie's Cafe";
      string desc1 = "Cute small cafe, long term customer.";

      string name2 = "Salt & Straw";
      string desc2 = "Best ice cream in Portland, they get pastries from us.";

      Vendor newVendor1 = new Vendor(name1, desc1);
      Vendor newVendor2 = new Vendor(name2, desc2);

      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}