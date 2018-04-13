namespace Sales_Taxes.ShoppingCarts
{
    interface ITaxStrategy
    {
        decimal getTaxes(decimal price, decimal taxRate);
    }
}
