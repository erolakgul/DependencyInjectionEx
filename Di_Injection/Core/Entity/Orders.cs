namespace Di_Injection.Core.Entity
{
    public class Orders
    {
        private decimal _total;

        public int ID { get; set; }
        public decimal Total
        {
            get
            {
                _total = OrderItems.Sum(x => x.Price * (decimal)x.Amount);
                return _total;
            }
            set { _total = value; }
        }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<OrderItems>? OrderItems { get; set; }
    }
}
