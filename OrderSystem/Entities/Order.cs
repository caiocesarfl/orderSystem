using System;
using System.Collections.Generic;
using System.Text;
using OrderSystem.Entities.Enum;

namespace OrderSystem.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(Client client)
        {
            Moment = DateTime.Now;
            Status = Enum.OrderStatus.Processing;
            Client = client;
        }

        public void AddOrderItem (OrderItem orderItem)
        {
            if (orderItem == null)
            {
                throw new ArgumentNullException(nameof(orderItem));
            }

            OrderItems.Add(orderItem);
        }

        public double Total ()
        {
            double total = 0;
            OrderItems.ForEach(orderItem => {
                total += orderItem.subTotal();
            });
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            OrderItems.ForEach(orderItem => {
                sb.AppendLine(orderItem.ToString());
            });
            sb.Append("Total price: ");
            sb.Append(Total());
            return sb.ToString();
        }

    }
   
}
