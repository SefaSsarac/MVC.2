namespace YourNamespace.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}