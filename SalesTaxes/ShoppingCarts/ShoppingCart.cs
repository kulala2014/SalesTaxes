using Sales_Taxes.Goods;
using System;
using System.Collections.Generic;

namespace Sales_Taxes.ShoppingCarts
{
    class ShoppingCart
    {
        private ITaxStrategy taxation;
        private List<ShoppingList> items;
        private decimal salesTaxes;
        private decimal totalPrice;

        public ShoppingCart(ITaxStrategy taxationStrategy)
        {
            this.taxation = taxationStrategy;
            this.items = new List<ShoppingList>();
        }

        public void add(int count, Good good)
        {
            ShoppingList item = new ShoppingList(count, good, taxation);
            salesTaxes += item.getTaxes();
            totalPrice += item.getPrice();
            items.Add(item);
        }

        public void printReceipt()
        {
            items.ForEach(x=>x.printGoodInfo());
            Console.WriteLine("Sales Taxes: {0}",salesTaxes);
            Console.WriteLine("Total:{0}\n", totalPrice);
        }

        public List<ShoppingList> getShoppingList()
        {
            return items;
        }

        public decimal getSalesTaxes()
        {
            return salesTaxes;
        }

        public decimal getTotalPrice()
        {
            return totalPrice;
        }
    }
}
