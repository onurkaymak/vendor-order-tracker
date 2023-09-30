using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    // Prompt wasn't very clear, this redirect the user to home page/splash page. (I think it should redirect to Vendor List Page.)
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }

    // Creates new order for selected Vendor.
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult CreateV(int vendorId, string title, string description, float price)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      string orderDate = DateTime.Now.ToString("dd/MM/yyyy");

      Order newOrder = new Order(title, description, price, orderDate);
      selectedVendor.AddOrder(newOrder);

      return RedirectToAction("Show", new { id = vendorId });
    }
  }
}