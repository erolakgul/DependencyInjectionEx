namespace Di_Injection.Core.Entity
{
    public class OrderItems
    {
        public int ID { get; set; }
        public int Product_ID { get; set; }
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
        public double Amount { get; set; }
        public int Order_FKID { get; set; }
        public Orders? Orders { get; set; }
    }
}
