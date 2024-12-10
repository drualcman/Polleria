using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazingPolleria.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public List<Pollo> Pizzas { get; set; } = new List<Pollo>();

        public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
