namespace Sales_Taxes.Goods
{
    class NormalGood:Good
    {
        private string name;
        private decimal taxRate;
        private decimal price;

        public NormalGood(string name, decimal taxRate, decimal price)
        {
            this.name = name;
            this.taxRate = taxRate;
            this.price = price;
        }

        public override string getGoodName()
        {
            return name;
        }

        public override decimal getTaxRate()
        {
            return taxRate;
        }

        public override decimal getPrice()
        {
            return price;
        }
    }
}
