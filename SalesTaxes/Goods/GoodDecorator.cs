namespace Sales_Taxes.Goods
{
    abstract class GoodDecorator:Good
    {
        protected Good good;

        public GoodDecorator(Good good)
        {
            this.good = good;
        }

        public override string getGoodName()
        {
            return good.getGoodName();
        }

        public override decimal getTaxRate()
        {
            return good.getTaxRate();
        }

        public override decimal getPrice()
        {
            return good.getPrice();
        }
    }
}
