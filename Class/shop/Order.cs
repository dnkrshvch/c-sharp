using System;
using System.Collections.Generic;

namespace Shop
{
    class Order
    {
        private string orderNumber;
        private List<Product> products;
        private decimal totalAmount;

        public Order(string orderNumber)
        {
            this.orderNumber = orderNumber;
            this.totalAmount = 0;
            this.products = new List<Product>();
        }

        public string OrderNumber => orderNumber;

        public decimal TotalAmount
        {
            get
            {
                CalcTotalAmount();
                return totalAmount;
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        private void CalcTotalAmount()
        {
            decimal subtotal = 0;
            foreach (var product in products)
            {
                subtotal += product.Price * product.Quantity;
            }
            totalAmount = subtotal;
        }

        public override string ToString()
        {
            string productInfo = string.Empty;
            foreach (var product in products)
            {
                productInfo += product.ToString() + "\n";
            }
            return $"Order Number: {OrderNumber}\nProducts:\n{productInfo}Total Amount: {TotalAmount:C}";
        }
    }
}
