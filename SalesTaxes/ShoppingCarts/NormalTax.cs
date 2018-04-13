using System;

namespace Sales_Taxes.ShoppingCarts
{
    class NormalTax : ITaxStrategy
    {
        private static decimal roundNum => 20.0M;

        public decimal getTaxes(decimal price, decimal taxRate)
        {
            decimal taxes = (decimal)((double)(price * taxRate) / 100.0);
            return Math.Ceiling(taxes * roundNum) / roundNum;
        }
    }
}
