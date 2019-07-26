using System;
using NUnit.Framework;

namespace KataTest.Help_the_bookseller
{
    [TestFixture]
    public class StockListTests {

        [Test]
        public void Test1() {
            string[] art = new string[] {"ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600"};
            String[] cd = new String[] {"A", "B"};
            Assert.AreEqual("(A : 200) - (B : 1140)", StockList.stockSummary(art, cd));
        }
    }
}