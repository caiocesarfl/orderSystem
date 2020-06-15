using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public double subTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Product: ");
            sb.Append(Product.Name);
            sb.Append(" Price: ");
            sb.Append(Price.ToString());
            sb.Append(" Quantity: ");
            sb.Append(Quantity.ToString());
            sb.Append(" Subtotal: ");
            sb.Append(subTotal().ToString());
            return sb.ToString();
        }
    }
}
