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
            Product = product;
        }

        public double SubTotal()
        {
            double subtotal = Quantity * Price;
            return subtotal;
        }


    }
}
