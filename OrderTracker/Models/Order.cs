using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string orderTitle, string orderDesc, float orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDesc;
      Price = orderPrice;
      Date = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}