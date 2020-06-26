using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask
{
    class Product
    {
        private string productName;
        private string productCategory;
        private decimal priceForOne;

        public Product()
        {

        }

        public Product(string name, string category, decimal price)
        {
            productName = name;
            productCategory = category;
            priceForOne = price;
        }

        public void SetName(string name)
        {
            productName = name;
        }

        public string GetName()
        {
            return productName;
        }

        public void SetCategory(string category)
        {
            productCategory = category;
        }

        public string GetCategory()
        {
            return productCategory;
        }

        public void SetPrice(decimal price)
        {
            priceForOne = price;
        }

        public decimal GetPrice()
        {
            return priceForOne;
        }
    }
}
