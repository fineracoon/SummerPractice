using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ShopTask
{
    class Shop
    {
        private string shopName;
        private List<Order> order;
        private static decimal deliveryCost;

        public Shop(decimal delivery_cost)
        {
            order = new List<Order>();
            deliveryCost = delivery_cost;
        }

        public Shop(string name, decimal delivery_cost)
        {
            order = new List<Order>();
            shopName = name;
            deliveryCost = delivery_cost;
        }

        public void SetShopName(string name)
        {
            shopName = name;
        }

        public string GetShopName()
        {
            return shopName;
        }

        public void AddNewOrder(Order o)
        {
            order.Add(o);
            o.GetCustomer().IncreaseOrderCount();
            Console.WriteLine("Заказ успешно принят");
        }

        public void DismissOrder(Order ordr)
        {
            foreach (Order o in order)
            {
                if (o.GetId() == ordr.GetId())
                {
                    order.Remove(o);
                    o.GetCustomer().DecreaseOrderCount();
                    Console.WriteLine("Заказ успешно отменен");
                    return;
                }
            }
        }

        public decimal GetDeliveryCost()
        {
            return deliveryCost;
        }
        
        public void CalculateOrderCostForCustomer(Customer c)
        {
            Console.WriteLine("Подсчет стоимости заказа для клиента " + c.GetName());
            foreach (Order o in order)
            {
                if (o.GetCustomer().GetName().Equals(c.GetName()))
                {
                    Console.WriteLine("Итого: " + (o.GetTotalCost() + deliveryCost).ToString(), CultureInfo.CurrentCulture);
                    return;
                }
            }
            Console.WriteLine("Клиент " + c.GetName() + " не делал(-а) заказ в этом магазине");
        }

    }
}
