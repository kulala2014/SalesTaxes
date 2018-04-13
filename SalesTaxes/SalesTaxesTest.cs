using Sales_Taxes.Goods;
using Sales_Taxes.ShoppingCarts;

namespace Sales_Taxes
{
    public class TestCaseResult
    {
        public decimal Taxes { get; set; }
        public decimal TotalPrice { get; set; }
    }
    public class SalesTaxesTest
    {
        ITaxStrategy taxationstrategy = new NormalTax();
        //Test case1
        public TestCaseResult GetResultForCase1()
        {
            //        Input 1:
            //        1 book at 12.49
            //        1 music CD at 14.99
            //        1 chocolate bar at 0.85

            //        Output 1:
            //        1 book : 12.49
            //        1 music CD: 16.49
            //        1 chocolate bar: 0.85
            //        Sales Taxes: 1.50
            //        Total: 29.83
            ShoppingCart shoppingCart = new ShoppingCart(taxationstrategy);
            Good book = new GoodFactory(GoodType.BOOK).getGood("book", 12.49M);
            Good generic = new GoodFactory(GoodType.GENERIC).getGood("music CD", 14.99M);
            Good food = new GoodFactory(GoodType.FOOD).getGood("chocolate bar", 0.85M);

            shoppingCart.add(1, book);
            shoppingCart.add(1, generic);
            shoppingCart.add(1, food);
            shoppingCart.printReceipt();

            return new TestCaseResult()
            {
                Taxes = shoppingCart.getSalesTaxes(),
                TotalPrice = shoppingCart.getTotalPrice()
            };
        }

        public TestCaseResult GetResultForCase2()
        {
            //        Input 2:
            //        1 imported box of chocolates at 10.00
            //        1 imported bottle of perfume at 47.50

            //        Output 2:
            //        1 imported box of chocolates: 10.50
            //        1 imported bottle of perfume: 54.65
            //        Sales Taxes: 7.65
            //        Total: 65.15
            ShoppingCart shoppingCart = new ShoppingCart(taxationstrategy);

            Good importGood1 = new ImportedGood(new GoodFactory(GoodType.FOOD).getGood("imported box of chocolates", 10.00M));
            Good importGood2 = new ImportedGood(new GoodFactory(GoodType.GENERIC).getGood("imported bottle of perfume", 47.50M));
            Good book = new GoodFactory(GoodType.BOOK).getGood("book", 12.49M);

            shoppingCart.add(1, importGood1);
            shoppingCart.add(1, importGood2);

            shoppingCart.printReceipt();

            return new TestCaseResult()
            {
                Taxes = shoppingCart.getSalesTaxes(),
                TotalPrice = shoppingCart.getTotalPrice()
            };
        }

        public TestCaseResult GetResultForCase3()
        {
            //        Input 3:
            //        1 imported bottle of perfume at 27.99
            //        1 bottle of perfume at 18.99
            //        1 packet of headache pills at 9.75
            //        1 box of imported chocolates at 11.25

            //        Output 3:
            //        1 imported bottle of perfume: 32.19
            //        1 bottle of perfume: 20.89
            //        1 packet of headache pills: 9.75
            //        1 imported box of chocolates: 11.85
            //        Sales Taxes: 6.70
            //        Total: 74.68

            ShoppingCart shoppingCart = new ShoppingCart(taxationstrategy);

            Good importGood1 = new ImportedGood(new GoodFactory(GoodType.GENERIC).getGood("imported bottle of perfume", 27.99M));
            Good normalGood1 = new GoodFactory(GoodType.GENERIC).getGood("bottle of perfume", 18.99M);
            Good normalGood2 = new GoodFactory(GoodType.MEDICAL).getGood("packet of headache pills", 9.75M);
            Good importGood2 = new ImportedGood(new GoodFactory(GoodType.FOOD).getGood("imported box of chocolates", 11.25M));

            shoppingCart.add(1, importGood1);
            shoppingCart.add(1, normalGood1);
            shoppingCart.add(1, normalGood2);
            shoppingCart.add(1, importGood2);
            shoppingCart.printReceipt();

            return new TestCaseResult()
            {
                Taxes = shoppingCart.getSalesTaxes(),
                TotalPrice = shoppingCart.getTotalPrice()
            };
        }
    }
}
