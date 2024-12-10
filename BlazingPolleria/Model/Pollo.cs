namespace BlazingPolleria.Model
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class Pollo
    {
        public const int DefaultSize = 500;
        public const int MinimumSize = 125;
        public const int MaximumSize = 1000;

        public int Id { get; set; }

        public int OrderId { get; set; }

        public PolloSpecial Special { get; set; }

        public int SpecialId { get; set; }

        public int Size { get; set; }

        public List<PolloTopping> Toppings { get; set; }

        public decimal GetBasePrice() =>
            Special is { FixedSize: not null }
              ? Special.BasePrice
              : (decimal)Size / DefaultSize * Special?.BasePrice ?? 1;

        public decimal GetTotalPrice()
        {
            return GetBasePrice();
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }

    }
}
