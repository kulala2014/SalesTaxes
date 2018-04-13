using Sales_Taxes.Goods;
using System;

namespace Sales_Taxes.ShoppingCarts
{
    class ShoppingList
    {
        private int count;
        private string name;
        private decimal price;
        private decimal taxes;

        public ShoppingList(int count, Good good, ITaxStrategy taxationStrategy)
        {
            this.count = count;
            this.name = good.getGoodName();

            decimal basePrice = this.count * good.getPrice();

            this.taxes = taxationStrategy.getTaxes(basePrice, good.getTaxRate());

            this.price = basePrice + this.taxes;

        }

        public void printGoodInfo()
        {
            Console.WriteLine("{0} {1} : {2}",count, name, price);
        }

        public decimal getPrice()
        {
            return price;
        }

        public decimal getTaxes()
        {
            return taxes;
        }
    }
}
