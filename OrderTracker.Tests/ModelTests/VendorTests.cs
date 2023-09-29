using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Test
{
  [TestClass]
  public class VendorTests
  {
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
  }
}