using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask
{
    class Customer
    {
        private string customerName;
        private string customerAdress;
        private double customerDiscount;
        private int orderCount;

        public Customer()
        {
            customerDiscount = 0.07;
            orderCount = 0;
        }

        public Customer(string name, string adress)
        {
            customerName = name;
            customerAdress = adress;
            customerDiscount = 0.07;
            orderCount = 0;
        }

        public void SetName(string name)
        {
            customerName = name;
        }

        public string GetName()
        {
            return customerName;
        }

        public void SetAdress(string adress)
        {
            customerAdress = adress;
        }

        public string GetAdress()
        {
            return customerAdress;
        }

        public void SetDiscount(double discount)
        {
            customerDiscount = discount;
        }

        public double GetDisount()
        {
            return customerDiscount;
        }

        public void SetOrderCount(int count)
        {
            orderCount = count;
        }

        public int GetOrderCount()
        {
            return orderCount;
        }

        public void ToString()
        {
            Console.WriteLine("Имя: " + customerName);
            Console.WriteLine("Адрес: " + customerAdress);
            Console.WriteLine("Персональная скидка: " + (customerDiscount * 100).ToString() + "%");
            Console.WriteLine("Совершено покупок: " + orderCount);
        }

        public void IncreaseOrderCount()
        {
            orderCount += 1;
            if (orderCount >= 20)
                customerDiscount = 0.15;
            else if (orderCount >= 10)
                customerDiscount = 0.1;
        }
        public void DecreaseOrderCount()
        {
            orderCount -= 1;
            if (orderCount >= 20)
                customerDiscount = 0.15;
            else if (orderCount >= 10)
                customerDiscount = 0.1;
        }
    }
}
