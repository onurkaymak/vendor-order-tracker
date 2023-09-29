using Microsoft.AspNetCore.Mvc;

namespace OrderTracker.Controllers
{
  public class HomeController : Controller
  {
    // Splash Page
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}