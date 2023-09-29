using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }

    public Vendor(string vendorName, string desc)
    {
      Name = vendorName;
      Description = desc;
      Id = _instances.Count;
    }
  }
}