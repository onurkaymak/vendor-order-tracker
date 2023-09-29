namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }

    public Order(string orderTitle, string orderDesc)
    {
      Title = orderTitle;
      Description = orderDesc;
    }
  }
}