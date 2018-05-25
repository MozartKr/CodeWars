using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class RemoveSmallestTests
    {
        private static void Tester(List<int> argument, List<int> expectedResult)
        {
            CollectionAssert.AreEqual(expectedResult, Remover.RemoveSmallest(argument));
        }
        [Test]
        public static void BasicTests()
        {
            Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
            Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
            Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
            Tester(new List<int>(), new List<int>());
        }
    }

    [TestFixture]
    public class AddBinaryTest
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual("11", Kata.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }
    }

    [TestFixture]
    public class StockListTests
    {

        [Test]
        public void Test1()
        {
            string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
            String[] cd = new String[] { "A", "B" };
            Assert.AreEqual("(A : 200) - (B : 1140)", StockList.stockSummary(art, cd));
        }
    }

    [TestFixture]
    public class ExpressionsMatter
    {
        [TestCase(6, 2, 1, 2)]
        [TestCase(3, 1, 1, 1)]
        [TestCase(4, 2, 1, 1)]
        [TestCase(9, 1, 2, 3)]
        [TestCase(5, 1, 3, 1)]
        [TestCase(8, 2, 2, 2)]
        public void CheckSmallValues(int expected, params int[] a)
        {
            Assert.That(Kata.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
        }
        [TestCase(020, 5, 1, 3)]
        [TestCase(105, 3, 5, 7)]
        [TestCase(035, 5, 6, 1)]
        [TestCase(008, 1, 6, 1)]
        [TestCase(014, 2, 6, 1)]
        [TestCase(048, 6, 7, 1)]
        public void CheckIntermediateValues(int expected, params int[] a)
        {
            Assert.That(Kata.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
        }
        [TestCase(060, 02, 10, 03)]
        [TestCase(027, 01, 08, 03)]
        [TestCase(126, 09, 07, 02)]
        [TestCase(020, 01, 01, 10)]
        [TestCase(018, 09, 01, 01)]
        [TestCase(300, 10, 05, 06)]
        [TestCase(012, 01, 10, 01)]
        public void CheckMixedValues(int expected, params int[] a)
        {
            Assert.That(Kata.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public static class SumDigPowerTests
    {

        private static string Array2String(long[] list)
        {
            return "[" + string.Join(", ", list) + "]";
        }
        private static void testing(long a, long b, long[] res)
        {
            Assert.AreEqual(Array2String(res),
                Array2String(SumDigPower.SumDigPow(a, b)));
        }
        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests SumDigPow");
            testing(1, 10, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            testing(1, 100, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 });
            testing(10, 100, new long[] { 89 });
            testing(90, 100, new long[] { });
            testing(90, 150, new long[] { 135 });
            testing(50, 150, new long[] { 89, 135 });
            testing(10, 150, new long[] { 89, 135 });

        }
    }

    [TestFixture]
    public class MorseCodeDecoderTests
    {
        [Test]
        public void MorseCodeDecoderBasicTest_1()
        {
            //try
            {
                string input = "...---...";
                string expected = "SOS";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            //catch (Exception ex)
            //{
            //    Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            //}
        }
    }

    [TestFixture]
    public class DubstepTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", Dubstep.SongDecoder("WUBWUBABCWUB"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("R L", Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public void World()
        {
            Assert.AreEqual("dlrow", Kata.Solution("world"));
        }

        [Test]
        public static void ShouldWorkForSomeExamples()
        {
            Assert.AreEqual(false, Kata.IsSquare(-1), "negative numbers aren't square numbers");
            Assert.AreEqual(false, Kata.IsSquare(3), "3 isn't a square number");
            Assert.AreEqual(true, Kata.IsSquare(4), "4 is a square number");
            Assert.AreEqual(true, Kata.IsSquare(25), "25 is a square number");
            Assert.AreEqual(false, Kata.IsSquare(26), "26 isn't a square number");
        }
    }

    [TestFixture]
    public class PersistTests
    {

        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(4, Persist.Persistence(999));
        }

    }
    [TestFixture]
    public class JadenCaseTest
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                "Strings didn't match.");
        }
    }

    [TestFixture]
    public class GetMiddleTest
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual("es", Kata.GetMiddle("test"));
            Assert.AreEqual("t", Kata.GetMiddle("testing"));
            Assert.AreEqual("dd", Kata.GetMiddle("middle"));
            Assert.AreEqual("A", Kata.GetMiddle("A"));
        }
    }

    [TestFixture]
    public class BasicTests
    {

        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                //yield return new TestCaseData("Dermatoglyphics").Returns(true);
                //yield return new TestCaseData("isogram").Returns(true);
                //yield return new TestCaseData("moose").Returns(false);
                //yield return new TestCaseData("isIsogram").Returns(false);
                //yield return new TestCaseData("aba").Returns(false);
                yield return new TestCaseData("moOse").Returns(false);
                //yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                //yield return new TestCaseData("").Returns(true);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string str)
        {
            return Kata.IsIsogram(str);
        }
    }

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
        public void Test1()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
        }

        [Test]
        public void ExampleTestsFindMissingLetter()
        {
            Assert.AreEqual('e', Kata.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Assert.AreEqual('P', Kata.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));

        }
        [Test]
        public void DuplicateEncodeTests()
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
        }

        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
        }

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
        public void ExampleTest()
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            Assert.AreEqual(200.0 / 13.0, AverageSolution.FindAverage(array));

            // Should return 0 on empty array
            Assert.AreEqual(0, AverageSolution.FindAverage(new double[] { }));
        }

        [Test, Description("Sample Tests")]
        public void SampleTestOrder()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", Kata.Order("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", Kata.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.AreEqual("", Kata.Order(""));
        }

        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", Kata.UniqueInOrder(""));
        }
        [Test]
        public void Test1()
        {
            //Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));

            Assert.AreEqual(new List<string> { "123", "45" }, Kata.UniqueInOrder(new List<string> { "123", "123", "45" }));
        }

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 3, 5 }, Kata.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, Kata.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, Kata.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Kata.Divisors(24));
        }

        [Test]
        public void GetIntegersFromList_MixedValues_ShouldPass_1()
        {
            var list = new List<object>() { 1, 2, "a", "b" };
            var expected = new List<int>() { 1, 2 };
            var actual = ListFilterer.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [Test]
        public void GetIntegersFromList_MixedValues_ShouldPass_2()
        {
            var list = new List<object>() { 1, "a", "b", 0, 15 };
            var expected = new List<int>() { 1, 0, 15 };
            var actual = ListFilterer.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [Test]
        public void GetIntegersFromList_MixedValues_ShouldPass_3()
        {
            var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            var expected = new List<int>() { 1, 2, 123 };
            var actual = ListFilterer.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(5, Kata.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        [Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
        public void LengthTest()
        {
            Assert.AreEqual(false, Kata.ValidatePin("1"), "Wrong output for \"1\"");
            Assert.AreEqual(false, Kata.ValidatePin("12"), "Wrong output for \"12\"");
            Assert.AreEqual(false, Kata.ValidatePin("123"), "Wrong output for \"123\"");
            Assert.AreEqual(false, Kata.ValidatePin("12345"), "Wrong output for \"12345\"");
            Assert.AreEqual(false, Kata.ValidatePin("1234567"), "Wrong output for \"1234567\"");
            Assert.AreEqual(false, Kata.ValidatePin("-1234"), "Wrong output for \"-1234\"");
            Assert.AreEqual(false, Kata.ValidatePin("1.234"), "Wrong output for \"1.234\"");
            Assert.AreEqual(false, Kata.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
            Assert.AreEqual(false, Kata.ValidatePin("00000000"), "Wrong output for \"00000000\"");
        }

        [Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
        public void NonDigitTest()
        {
            Assert.AreEqual(false, Kata.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, Kata.ValidatePin(".234"), "Wrong output for \".234\"");
        }

        [Test, Description("ValidatePin should return true for valid pins")]
        public void ValidTest()
        {
            Assert.AreEqual(true, Kata.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, Kata.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, Kata.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, Kata.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, Kata.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, Kata.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, Kata.ValidatePin("090909"), "Wrong output for \"090909\"");
        }

        [Test]
        public void EncryptExampleTests()
        {
            Assert.AreEqual("This is a test!", Kata.Encrypt("This is a test!", 0));
            Assert.AreEqual("hsi  etTi sats!", Kata.Encrypt("This is a test!", 1));
            Assert.AreEqual("s eT ashi tist!", Kata.Encrypt("This is a test!", 2));
            Assert.AreEqual(" Tah itse sits!", Kata.Encrypt("This is a test!", 3));
            Assert.AreEqual("This is a test!", Kata.Encrypt("This is a test!", 4));
            Assert.AreEqual("This is a test!", Kata.Encrypt("This is a test!", -1));
            Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig", Kata.Encrypt("This kata is very interesting!", 1));
        }

        [Test]
        public void DecryptExampleTests()
        {
            Assert.AreEqual("This is a test!", Kata.Decrypt("This is a test!", 0));
            Assert.AreEqual("This is a test!", Kata.Decrypt("hsi  etTi sats!", 1));
            Assert.AreEqual("This is a test!", Kata.Decrypt("s eT ashi tist!", 2));
            Assert.AreEqual("This is a test!", Kata.Decrypt(" Tah itse sits!", 3));
            Assert.AreEqual("This is a test!", Kata.Decrypt("This is a test!", 4));
            Assert.AreEqual("This is a test!", Kata.Decrypt("This is a test!", -1));
            Assert.AreEqual("This kata is very interesting!", Kata.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
        }

        [Test]
        public void EmptyTests()
        {
            Assert.AreEqual("", Kata.Encrypt("", 0));
            Assert.AreEqual("", Kata.Decrypt("", 0));
        }

        [Test]
        public void NullTests()
        {
            Assert.AreEqual(null, Kata.Encrypt(null, 0));
            Assert.AreEqual(null, Kata.Decrypt(null, 0));
        }

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
        public void KataTestsDuplicateCount()
        {
            Assert.AreEqual(0, Kata.DuplicateCount(""));
            Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
            Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }

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