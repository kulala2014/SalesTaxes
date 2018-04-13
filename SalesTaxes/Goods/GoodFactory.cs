namespace Sales_Taxes.Goods
{
    class GoodFactory
    {
        private decimal taxRate;

        public GoodFactory(decimal taxRate)
        {
            this.taxRate = taxRate;
        }

        public Good getGood(string name, decimal price)
        {
            return new NormalGood(name, taxRate, price);
        }
    }

    public class GoodType
    {
        public static decimal BOOK => 0.0M;
        public static decimal FOOD => 0.0M;
        public static decimal MEDICAL => 0.0M;
        public static decimal GENERIC => 10.0M;
    }
}
