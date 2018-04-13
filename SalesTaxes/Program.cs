using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sales_Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test case 1
            Console.WriteLine("Output 1:\n");
            var test = new SalesTaxesTest();
            var result = test.GetResultForCase1();
            Assert.AreEqual(1.50m, result.Taxes);
            Assert.AreEqual(29.83m, result.TotalPrice);

            //Test case 2
            Console.WriteLine("Output 2:\n");
            result = test.GetResultForCase2();
            Assert.AreEqual(7.65m, result.Taxes);
            Assert.AreEqual(65.15m, result.TotalPrice);

            //Test case 3
            Console.WriteLine("Output 3:\n");
            result = test.GetResultForCase3();
            Assert.AreEqual(6.70m, result.Taxes);
            Assert.AreEqual(74.68m, result.TotalPrice);

            Console.ReadLine();
        }
    }
}
