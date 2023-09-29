namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }

    public Order(string orderTitle)
    {
      Title = orderTitle;
    }
  }
}