namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }

    public Order(string orderTitle, string orderDesc, float orderPrice)
    {
      Title = orderTitle;
      Description = orderDesc;
      Price = orderPrice;
    }
  }
}