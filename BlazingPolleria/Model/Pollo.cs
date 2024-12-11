namespace BlazingPolleria.Model
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class Pollo
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public PolloSpecial Special { get; set; }

        public int SpecialId { get; set; }

        public List<PolloTopping> Toppings { get; set; }

        public decimal GetBasePrice() =>
            Special?.BasePrice ?? 1;

        public decimal GetTotalPrice()
        {
            decimal basePrice = GetBasePrice();
            decimal toppings = Toppings.Sum(t => t.Topping.Price);
            return basePrice + toppings;
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }

    }
}
