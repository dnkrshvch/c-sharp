using System;

namespace Shop
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public static int TotalProductsAdded { get; private set; } = 0;

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            TotalProductsAdded++;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price:C}, Quantity: {Quantity}";
        }
    }
}
