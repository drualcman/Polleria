namespace BlazingPolleria.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public List<Pollo> Pollos { get; set; } = new List<Pollo>();

        public decimal GetTotalPrice() => Pollos.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
