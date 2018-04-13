namespace Sales_Taxes.Goods
{
    class ImportedGood : GoodDecorator
    {
        private static decimal importTaxRate => 5.0m;

        public ImportedGood(Good good):base(good)
        {
        }

        public override decimal getTaxRate()
        {
            return base.getTaxRate() + importTaxRate;
        }
    }
}
