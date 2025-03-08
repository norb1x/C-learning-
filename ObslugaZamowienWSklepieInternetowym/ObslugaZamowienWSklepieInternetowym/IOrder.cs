namespace OrderManagementApp.Model
{
    public interface IOrder
    {
        string Id { get; set; }
        List<string> Items { get; set; }
        decimal Price { get; set; }
        string ShippingAddress { get; set; }
        void DisplayDetails();
    }
}
