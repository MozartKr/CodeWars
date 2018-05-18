using System;
using System.Collections.Generic;
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

        [TestCase("a clash of KINGS", "a an the of", "A Clash of Kings")]
        [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
        public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
        {
            Assert.AreEqual(expected, Kata.TitleCase(sampleTitle, sampleMinorWords));
        }
        [Test]
        public void MyTest2()
        {
            Assert.AreEqual("", Kata.TitleCase(""));
        }
        [Test]
        public void MyTest3()
        {
            Assert.AreEqual("The Quick Brown Fox", Kata.TitleCase("the quick brown fox"));
        }

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(Kata.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }), 4);
            Assert.AreEqual(Kata.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }), 2);
            Assert.AreEqual(Kata.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }), 1);
            Assert.AreEqual(Kata.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }), 0);
        }

        private string[] urls = new string[] {"mysite.com/pictures/holidays.html",
                                          "www.codewars.com/users/GiacomoSorbi?ref=CodeWars",
                                          "www.microsoft.com/docs/index.htm#top",
                                          "mysite.com/very-long-url-to-make-a-silly-yet-meaningful-example/example.asp",
                                          "www.very-long-site_name-to-make-a-silly-yet-meaningful-example.com/users/giacomo-sorbi",
                                          "https://www.linkedin.com/in/giacomosorbi",
                                          "www.agcpartners.co.uk/",
                                          "www.agcpartners.co.uk",
                                          "https://www.agcpartners.co.uk/index.html",
                                          "http://google.ca/web/paper-uber-cauterization-eurasian-diplomatic/#info"};

        private string[] seps = new string[] { " : ", " / ", " * ", " > ", " + ", " * ", " * ", " # ", " >>> ", " - " };


        private string[] anss = new string[] {"<a href=\"/\">HOME</a> : <a href=\"/pictures/\">PICTURES</a> : <span class=\"active\">HOLIDAYS</span>",
                                          "<a href=\"/\">HOME</a> / <a href=\"/users/\">USERS</a> / <span class=\"active\">GIACOMOSORBI</span>",
                                          "<a href=\"/\">HOME</a> * <span class=\"active\">DOCS</span>",
                                          "<a href=\"/\">HOME</a> > <a href=\"/very-long-url-to-make-a-silly-yet-meaningful-example/\">VLUMSYME</a> > <span class=\"active\">EXAMPLE</span>",
                                          "<a href=\"/\">HOME</a> + <a href=\"/users/\">USERS</a> + <span class=\"active\">GIACOMO SORBI</span>",
                                          "<a href=\"/\">HOME</a> * <a href=\"/in/\">IN</a> * <span class=\"active\">GIACOMOSORBI</span>",
                                          "<span class=\"active\">HOME</span>",
                                          "<span class=\"active\">HOME</span>",
                                          "<span class=\"active\">HOME</span>",
                                          "<a href=\"/\">HOME</a> - <a href=\"/web/\">WEB</a> - <span class=\"active\">PUCED</span>"};
        [Test]
        public void ExampleTestsGenerateBC()
        {
            for (int i = 9; i < 10; i++)
            {
                Console.WriteLine("\nTest With: {0}", urls[i]);
                if (i == 5) Console.WriteLine("\nThe one used in the above test was my LinkedIn Profile; if you solved the kata this far and manage to get it, feel free to add me as a contact, message me about the language that you used and I will be glad to endorse you in that skill and possibly many others :)\n\n ");

                Assert.AreEqual(anss[i], Kata.GenerateBC(urls[i], seps[i]));
            }
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

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }
    }

    [TestFixture]
    public class WhichAreInTests
    {
        [Test]
        public void Test1()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
    }

    [TestFixture]
    public class Sample_Tests
    {
        private static object[] testCases = new object[]
        {
            new object[]
            {
                "Finished!",
                new int[][]
                {
                    new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                    new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                    new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                    new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                    new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                    new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                    new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                    new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                    new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
                },
            },
            new object[]
            {
                "Try again!",
                new int[][]
                {
                    new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                    new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                    new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
                    new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
                    new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                    new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
                    new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                    new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                    new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
                },
            },
        };

        [Test, TestCaseSource("testCases")]
        public void Test(string expected, int[][] board)
        {
            Assert.AreEqual(expected, Sudoku.DoneOrNot(board));
        }

        private static IEnumerable<TestCaseData> testCasesAlphanumeric
        {
            get
            {
                yield return new TestCaseData("Mazinkaiser").Returns(true);
                yield return new TestCaseData("hello world_").Returns(false);
                yield return new TestCaseData("PassW0rd").Returns(true);
                yield return new TestCaseData("     ").Returns(false);
                yield return new TestCaseData("helloworld_").Returns(false);
                yield return new TestCaseData("").Returns(false);
                yield return new TestCaseData("_").Returns(false);
            }
        }

        [Test, TestCaseSource("testCasesAlphanumeric")]
        public bool TestAlphanumeric(string str)
        {
            return Kata.Alphanumeric(str);
        }
    }

    [TestFixture]
    public class SumSquaredDivisorsTests
    {

        [Test]
        public void Test01()
        {
            Assert.AreEqual("[[1, 1], [42, 2500], [246, 84100]]", SumSquaredDivisors.listSquared(1, 250));
        }
        [Test]
        public void Test02()
        {
            Assert.AreEqual("[[42, 2500], [246, 84100]]", SumSquaredDivisors.listSquared(42, 250));
        }
        [Test]
        public void Test03()
        {
            Assert.AreEqual("[[287, 84100]]", SumSquaredDivisors.listSquared(250, 500));
        }
    }

    [TestFixture]
    public class HumanReadableTimeTest
    {
        [Test]
        public void HumanReadableTest()
        {
            Assert.AreEqual("00:00:00", TimeFormat.GetReadableTime(0));
            Assert.AreEqual("00:00:05", TimeFormat.GetReadableTime(5));
            Assert.AreEqual("00:01:00", TimeFormat.GetReadableTime(60));
            Assert.AreEqual("23:59:59", TimeFormat.GetReadableTime(86399));
            Assert.AreEqual("99:59:59", TimeFormat.GetReadableTime(359999));
        }
    }

    [TestFixture]
    public static class ToSmallestTests
    {

        private static void testing(long n, string res)
        {
            Assert.AreEqual(res, Array2String(ToSmallest.Smallest(n)));
        }
        private static string Array2String(long[] list)
        {
            return "[" + string.Join(", ", list) + "]";
        }
        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests smallest");
                
            testing(817253678486335648, "[172536784863356488, 0, 16]");
            testing(209917, "[29917, 0, 1]");
            testing(635901196224570400, "[63590119622457040, 16, 0]");
        }
    }
}