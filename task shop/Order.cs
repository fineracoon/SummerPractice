using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ShopTask
{
    class Order
    {
        private int orderId;
        private List<Basket> basket;
        private Customer customer;
        private decimal totalCost;

        public Order(int id)
        {
            orderId = id;
            basket = new List<Basket>();
        }
        public Order(int id, Product p, Customer c, int count)
        {
            orderId = id;
            basket = new List<Basket>();
            basket.Add(new Basket(p, count));
            customer = c;
        }

        public Customer GetCustomer()
        {
            return customer;
        }

        public int GetId()
        {
            return orderId;
        }

        public void SetNewCustomer(Customer c)
        {
            customer = c;
        }

        public void WhoIsCustomer()
        {
            customer.ToString();
        }

        public decimal GetTotalCost()
        {
            return totalCost;
        }

        public void PrintBasket()
        {
            Console.WriteLine("Корзина заказчика " + customer.GetName());
            foreach (Basket b in basket)
            {
                b.ToString();
            }
        }

        public void AddProductToBasket(Product p, int count)
        {
            basket.Add(new Basket(p, count));
        }

        public void CalculateTotalPrice()
        {
            totalCost = Decimal.Zero;
            foreach (Basket b in basket)
            {
                totalCost += b.GetCommonPrice();
            }
            totalCost -= totalCost * (decimal)customer.GetDisount();
            Console.WriteLine("Итого за заказ: " + totalCost, CultureInfo.CurrentCulture);
        }
    }
}
