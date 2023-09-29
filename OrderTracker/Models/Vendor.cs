using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string desc)
    {
      Name = vendorName;
      Description = desc;
      Id = _instances.Count;
      _instances.Add(this);
      Orders = new List<Order> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}