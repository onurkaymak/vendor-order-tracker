using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      Order selectedOrder = Order.Find(orderId);

      Dictionary<string, object> model = new Dictionary<string, object> { };

      model.Add("vendor", selectedVendor);
      model.Add("order", selectedOrder);
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);

      return View(selectedVendor);
    }
  }
}