using System;

namespace ShopTask
{
    class TaskShop
    {
        static void Main(string[] args)
        {
            Shop sh1 = new Shop("Texno+", (decimal)1.2);
            Shop sh2 = new Shop((decimal)0.76);
            sh2.SetShopName("Zeus");

            Product p1 = new Product("Чайник электрический", "Бытовые электроприборы", (decimal)64.75);
            Product p2 = new Product("Пылесос", "Бытовые электроприборы", (decimal)120.30);
            Product p3 = new Product("Однотонные бумажные обои", "Ремонт", (decimal)84.01);
            Product p4 = new Product();
            p4.SetName("Керамическая плитка");
            p4.SetCategory("Ремонт");
            p4.SetPrice((decimal)76.34);

            Customer c1 = new Customer("Джон Смитт", "ул.К.Маркса, д.29"); // по умолчанию скидка 7% 
            Customer c2 = new Customer();
            c2.SetName("Дарья Моргендорфер");
            c2.SetAdress("Вечнозеленая аллея, д.45");
            c2.SetDiscount(0.10);
            c2.SetOrderCount(14);

            Order o1 = new Order(1247, p3, c1, 5);
            o1.AddProductToBasket(p4, 1);
            o1.AddProductToBasket(p2, 3);
            o1.WhoIsCustomer();
            o1.PrintBasket();
            o1.CalculateTotalPrice();

            Console.WriteLine();

            Order o2 = new Order(3241);
            o2.SetNewCustomer(c2);
            o2.AddProductToBasket(p1, 2);
            o2.PrintBasket();
            o2.CalculateTotalPrice();
            Console.WriteLine();

            Console.WriteLine("Магазин " + sh1.GetShopName());
            sh1.AddNewOrder(o1);
            sh1.AddNewOrder(o2);
            sh1.DismissOrder(o2);
            sh1.CalculateOrderCostForCustomer(c1);
            sh1.CalculateOrderCostForCustomer(c2);

            Console.WriteLine("\r\nМагазин " + sh2.GetShopName());
            sh2.AddNewOrder(o2);
            sh2.CalculateOrderCostForCustomer(c2);

            Console.ReadKey();
        }
    }
}
