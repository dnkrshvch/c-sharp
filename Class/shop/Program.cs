using System;

namespace Shop
{
    class Program
    {
        public static void Main(string[] args)
        {
            var product1 = new Product("Item1", 100, 2);
            var product2 = new Product("Item2", 80, 1);

            var order = new Order("ORD123");
            order.AddProduct(product1);
            order.AddProduct(product2);

            Console.WriteLine($"Номер заказа: {order.OrderNumber}");
            Console.WriteLine($"Итоговая сумма: {order.TotalAmount:C}");

            Console.WriteLine($"Общее количество товаров в системе: {Product.TotalProductsAdded}");
        }
    }
}
