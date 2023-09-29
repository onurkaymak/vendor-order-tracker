using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OrderTracker.Models;
using System;

namespace OrderTracker
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      WebApplication app = builder.Build();

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );


      //// To Vendor routes, created default vendors
      string name1 = "Suzie's Cafe";
      string desc1 = "Cute small cafe, long term customer.";

      string name2 = "Salt & Straw";
      string desc2 = "Best ice cream in Portland, they get pastries from us.";

      Vendor newVendor1 = new Vendor(name1, desc1);
      Vendor newVendor2 = new Vendor(name2, desc2);

      app.Run();
    }
  }
}