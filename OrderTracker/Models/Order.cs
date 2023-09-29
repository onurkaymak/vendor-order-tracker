namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }

    public Order(string orderTitle, string orderDesc, float orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDesc;
      Price = orderPrice;
      Date = orderDate;
    }
  }
}