using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask
{
    // класс Корзина, который позволяет хранить вместе заказываемый продукт и его количество
    class Basket
    {
        private Product product;
        private int count;

        public Basket(Product p, int c)
        {
            product = p;
            count = c;
        }

        public decimal GetCommonPrice()
        {
            return product.GetPrice() * count;
        }

        public void ToString()
        {
            Console.WriteLine("Товар: " + product.GetName() + '\r' + '\n' +
                              "Количесто: " + count);
        }
    }
}
