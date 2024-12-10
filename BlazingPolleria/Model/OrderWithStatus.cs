using System;
using System.Collections.Generic;

namespace BlazingPolleria.Model
{
    public class OrderWithStatus
    {
        public readonly static TimeSpan PreparationDuration = TimeSpan.FromSeconds(10);
        public readonly static TimeSpan DeliveryDuration = TimeSpan.FromMinutes(1); // Irreal, pero más interesante de ver

        public Order Order { get; set; }

        public string StatusText { get; set; }

        public bool IsDelivered => StatusText == "Delivered";

        public static OrderWithStatus FromOrder(Order order)
        {
            // Para simular un proceso de backend real, falsificamos actualizaciones de estado 
            // según la cantidad de tiempo desde que se realizó el pedido
            string statusText;
            var dispatchTime = order.CreatedTime.Add(PreparationDuration);

            if (DateTime.Now < dispatchTime)
            {
                statusText = "Preparando";
            }
            else if (DateTime.Now < dispatchTime + DeliveryDuration)
            {
                statusText = "Enviado para entrega";
            }
            else
            {
                statusText = "Entregado";
            }

            return new OrderWithStatus
            {
                Order = order,
                StatusText = statusText
            };
        }


    }
}
