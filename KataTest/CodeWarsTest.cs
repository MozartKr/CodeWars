using System;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class ValidateWordTest
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual(3, Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.AreEqual(1, Kata.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.AreEqual(-1, Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, Kata.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
    }

    [TestFixture]
    public class KataOpenOrSeniorTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
        }

    }

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, Kata.FindShort("turns out random test cases are easier than writing out basic ones"));
        }

        [TestCase]
        public void GetNumberOfYears0()
        {
            Assert.AreEqual(0, Kata.CalculateYears(1000, 0.05, 0.18, 1000));
        }

        [TestCase]
        public void GetNumberOfYears1()
        {
            Assert.AreEqual(14, Kata.CalculateYears(1000, 0.01625, 0.18, 1200));
        }

        [TestCase]
        public void GetNumberOfYears2()
        {
            Assert.AreEqual(5, Kata.CalculateYears(7009.53279482645, 0.223176315996412, 0.0519420714918254, 15370.9598236582));
        }

        [Test]
        public void BasicTestsSort()
        {
            Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Assert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
        }

        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(8, Kata.DontGiveMeFive(1, 9));
            Assert.AreEqual(12, Kata.DontGiveMeFive(4, 17));
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, Kata.XO("xo"));
            Assert.AreEqual(true, Kata.XO("xxOo"));
            Assert.AreEqual(false, Kata.XO("xxxm"));
            Assert.AreEqual(false, Kata.XO("Oo"));
            Assert.AreEqual(false, Kata.XO("ooom"));
        }
    }

    [TestFixture]
    public static class AccumulTests
    {

        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            testing(Accumul.Accum("ZpglnRxqenU"), "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu");
            testing(Accumul.Accum("NyffsGeyylB"), "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb");
            testing(Accumul.Accum("MjtkuBovqrU"), "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu");
            testing(Accumul.Accum("EvidjUnokmM"), "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm");
            testing(Accumul.Accum("HbideVbxncC"), "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc");
        }
    }

    [TestFixture]
    public class XbonacciTest
    {
        private Xbonacci variabonacci;

        [SetUp]
        public void SetUp()
        {
            variabonacci = new Xbonacci();
        }

        [TearDown]
        public void TearDown()
        {
            variabonacci = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, variabonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));
        }
    }

    [TestFixture]
    public class DnaStrandTest
    {
        [TestCase]
        public void test01()
        {
            Assert.AreEqual("TTTT", DnaStrand.MakeComplement("AAAA"));
        }
        [TestCase]
        public void test02()
        {
            Assert.AreEqual("TAACG", DnaStrand.MakeComplement("ATTGC"));
        }
        [TestCase]
        public void test03()
        {
            Assert.AreEqual("CATA", DnaStrand.MakeComplement("GTAT"));
        }
    }

    [TestFixture]
    public static class ArgeTests
    {

        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing NbYear");
            testing(Arge.NbYear(1500, 5, 100, 5000), 15);
            testing(Arge.NbYear(1500000, 2.5, 10000, 2000000), 10);
            testing(Arge.NbYear(1500000, 0.25, 1000, 2000000), 94);
        }
    }

    [TestFixture]
    public class ConverterTests
    {
        [Test]
        public void Test1()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, Kata.sumTwoSmallestNumbers(numbers));
        }
    }

    [TestFixture]
    public class NumberTest
    {
        private Number num;

        [SetUp]
        public void SetUp()
        {
            num = new Number();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(6, num.DigitalRoot(132189));
            Assert.AreEqual(7, num.DigitalRoot(16));
        }
    }
}
