namespace Sales_Taxes.Goods
{
    abstract class Good
    {
        public abstract string getGoodName();
        public abstract decimal getTaxRate();
        public abstract decimal getPrice();
    }
}
