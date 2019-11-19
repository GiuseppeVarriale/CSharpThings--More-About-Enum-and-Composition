using System;
using System.Collections.Generic;
using System.Text;
using MoreAboutCompositionAndEnum.Entities;

namespace MoreAboutCompositionAndEnum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Price = product.Price;
        }

        public double SubTotal(int quantity, double price)
        {
            double subtotal = quantity * price;
            return subtotal;
        }


    }
}
