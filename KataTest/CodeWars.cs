using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KataTest
{
    class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            return array.Length > 0 ? array.Average() : 0.0;
        }
    } 

    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            //numbers.Remove(numbers.FirstOrDefault(i => numbers.Min() == i));
            numbers.Remove(numbers.DefaultIfEmpty().Min());
            return numbers;
        }
    }

    public class StockList
    {
        class Art
        {
            public string Name { get; set; }
            public int Count { get; set; }
        }

        class Stock
        {
            public char Key { get; set; }
            public int Count { get; set; }

            public override string ToString()
            {
                return string.Format("({0} : {1})", Key, Count);
            }
        }

        public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
        {
            var artList = lstOfArt.Select(s => s.Split(' ')).Select(artInfo => new Art {Name = artInfo[0], Count = Convert.ToInt32(artInfo[1])}).ToList();
            var stockList = lstOf1stLetter.Select(s => new Stock {Key = Convert.ToChar(s)}).ToList();

            foreach (Art art in artList)
            {
                var findStock = stockList.Find(stock => stock.Key == art.Name[0]);
                if (findStock != null) findStock.Count += art.Count;
            }

            return stockList.Any(stock => stock.Count > 0) ? string.Join(" - ", stockList) : string.Empty;
        }
    }

    public class SumDigPower
    {
        public static long[] SumDigPow(long a, long b)
        {
            var listNum = new List<long>();
            for (var i = a; i <= b; i++)
            {
                var strInt = i.ToString();
                var sum = strInt.Select((x, idx) => (int)Math.Pow(Convert.ToInt32(x.ToString()), idx+1)).Sum();
                if (i == sum) listNum.Add(i);
            }
            return listNum.ToArray();
        }
    }

    class MorseCodeDecoder
    {
        private static Dictionary<string, string> morseCodeTable = new Dictionary<string, string>
        {
            {".-", "A"},
            {"-...", "B"},
            {"-.-.", "C"},
            {"-..", "D"},
            {".", "E"},
            {"..-.", "F"},
            {"--.", "G"},
            {"....", "H"},
            {"..", "I"},
            {".---", "J"},
            {"-.-", "K"},
            {".-..", "L"},
            {"--", "M"},
            {"-.", "N"},
            {"---", "O"},
            {".--.", "P"},
            {"--.-", "Q"},
            {".-.", "R"},
            {"...", "S"},
            {"-", "T"},
            {"..-", "U"},
            {"...-", "V"},
            {".--", "W"},
            {"-..-", "X"},
            {"-.--", "Y"},
            {"--..", "Z"},
            {"...---...", "SOS"}
        };
        
        public static string Decode(string morseCode)
        {
            morseCode = morseCode.Replace("   ", " X ");
            return string.Concat(morseCode.Split(' ').Select(s => s == "X" ? " " : morseCodeTable[s])).Trim();
        }

    }
    public class Dubstep
    {
        public static string SongDecoder(string input)
        {
            return string.Join(" ", Regex.Split(input, "WUB").Where(s => !string.IsNullOrWhiteSpace(s)));
        }
    }

    public class Persist
    {
        public static int Persistence(long n)
        {
            if (n < 10) return 0;
            var digitList = n.ToString().Select(c => Convert.ToInt32(c.ToString()));
            n = digitList.Aggregate(1L, (current, i) => current * i);
            return Persistence(n) + 1;
        }
    }

    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.Where(i => i is int).Cast<int>();
        }
    }

    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
            //return phrase.Split(' ').Select(s => );
        }
    }

    public class Kata
    {
        public static string Solution(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        public static int DuplicateCount(string str)
        {
            //return str.ToLower().ToList().Distinct().Count(c => str.ToLower().Count(c1 => c == c1) > 1);
            return str.ToLower().GroupBy(c => c).Count(g => g.Count() > 1);
        }

        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }

        public static int ExpressionsMatter(int a, int b, int c)
        {
            return GetCalcResults(a, b, c).Max();
        }

        private static IEnumerable<int> GetCalcResults(int a, int b, int c)
        {
            yield return a * (b + c);
            yield return a * b * c;
            yield return a + b * c;
            yield return (a + b) * c;
            yield return a + b + c;
        }

        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(name => name.Length == 4);
        }

        public static string Order(string words)
        {
            //var sortedWords = words.Split(' ').OrderBy(s => char.GetNumericValue(s[s.IndexOfAny(s.Where(char.IsDigit).ToArray())]));
            var sortedWords = words.Split(' ').OrderBy(s => s.ToList().Find(char.IsDigit));
            return string.IsNullOrWhiteSpace(words) ? words : string.Join(" ", sortedWords);
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            //return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
            //    numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7], numbers[8], numbers[9]);

            return new Regex("(...)(...)(....)").Replace(String.Concat(numbers), "($1) $2-$3");
        }

        public static char FindMissingLetter(char[] array)
        {
            for (var i = 0; i < array.Length-1; i++)
            {
                var ascilValue = (int) array[i];
                var ascilValueCompare = (int) array[i + 1];
                if (ascilValue + 1 != ascilValueCompare) return (char) (ascilValue + 1);
            }
            return ' ';
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var prev = default(T);
            foreach (var item in iterable)
            {
                //if (prev == null || !prev.Equals(item))
                if (!item.Equals(prev))
                {
                    prev = item;
                    yield return item;
                }
            }
        }

        public static int[] Divisors(int n)
        {
            var divisors = new List<int>();
            var max = (int) Math.Sqrt(n);
            for (var i = 2; i <= max; i++)
            {
                if (n % i != 0) continue;
                divisors.Add(i);
                if (i != n / i) divisors.Add(n / i);
            }
            return divisors.Count == 0 ? null : divisors.OrderBy(i => i).ToArray();
        }

        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            var duplicateList = new List<char>();
            foreach (var c in word)
            {
                if (word.Count(c1 => c1 == c) > 1)
                    duplicateList.Add(c);
            }
            return string.Concat(word.Select(c => duplicateList.Contains(c) ? ')' : '('));
        }

        public static bool IsSquare(int n)
        {
            if (n < 0) return false;
            var sqrtValue = Math.Sqrt(n);
            return sqrtValue.Equals(Math.Floor(sqrtValue));
        }

        public static string GetMiddle(string s)
        {
            return s.Length % 2 == 1 ? 
                s[s.Length / 2].ToString() :
                string.Concat(s[s.Length / 2 - 1], s[s.Length / 2]);
        }

        public static int find_it(int[] seq)
        {
            foreach (var i in seq)
            {
                if (seq.Count(j => j == i) % 2 == 1) return i;
            }
            return -1;
        }

        public static bool ValidatePin(string pin)
        {
            return Regex.IsMatch(pin, @"^(\d{4}|\d{6})$");
        }

        public static int GetVowelCount(string str)
        {
            var vowels = new[] {'a', 'e', 'i', 'o', 'u'};
            return str.Count(c => vowels.Contains(c));
        }

        public static bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count() == str.Length;
        }

        public static string Encrypt(string text, int n)
        {
            if (text == null) return null;
            if (n <= 0) return text;

            var encryptionText = string.Join("", text.Where((c, i) => i % 2 == 1)) +
                                 string.Join("", text.Where((c, i) => i % 2 == 0));
            n--;
            return n == 0 ? encryptionText : Encrypt(encryptionText, n);
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if (encryptedText == null) return null;
            if (n <= 0) return encryptedText;

            var decryptionList = encryptedText.Where((c, i) => i >= encryptedText.Length / 2).ToList();
            var twoList = encryptedText.Where((c, i) => i < encryptedText.Length / 2).ToList();
            for (var i = 0; i < twoList.Count; i++)
            {
                decryptionList.Insert(i * 2 + 1, twoList[i]);
            }
            var decryptionText = string.Join("", decryptionList);
            n--;
            return n == 0 ? decryptionText : Decrypt(decryptionText, n);
        }

        public static int FindEvenIndex(int[] arr)
        {
            if (arr.Length >= 1000) return -1;

            int leftSum = 0;
            int rightSum = 0;
            int evenIdx = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                rightSum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }
                if (leftSum == rightSum)
                {
                    evenIdx = i;
                    break;
                }
                leftSum += arr[i];
            }

            return evenIdx;
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var result = new string[data.Length];

            for (var i = 0; i < data.Length; i++)
            {
                if (data[i][0] >= 55 & data[i][1] > 7) result[i] = "Senior";
                else result[i] = "Open";
            }

            return result;
        }

        public static int FindShort(string s)
        {
            return s.Split(' ').Select(word => word.Length).Min();
        }

        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            if (principal == desiredPrincipal)
                return 0;

            var calcPrincipal = principal + ((principal * interest) - (principal * interest * tax));

            if (calcPrincipal >= desiredPrincipal)
                return 1;

            return CalculateYears(calcPrincipal, interest, tax, desiredPrincipal) + 1;
        }

        public static bool XO(string input)
        {
            return input.ToUpper().Count(ch => ch == 'X') == input.ToUpper().Count(ch => ch == 'O');
        }

        public static int[] SortArray(int[] array)
        {
            var list = array.Select(i => i % 2 != 0 ? int.MaxValue : i).ToList();

            var oddList = array.Where(i => i % 2 != 0).ToList();
            oddList.Sort();

            foreach (var i in list.ToList())
            {
                if (i != int.MaxValue) continue;
                list[list.IndexOf(i)] = oddList.First();
                oddList.RemoveAt(0);
            }

            return list.ToArray();
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();
        }

        public static int DontGiveMeFive(int start, int end)
        {
            var arrayWithoutFive = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i.ToString().All(c => c != '5'))
                    arrayWithoutFive.Add(i);
            }
            return arrayWithoutFive.Count;
        }

        public static string PigIt(string str)
        {
            return string.Join(" ", str.Split(' ').Select(s => s.Substring(1, s.Length - 1) + s.Substring(0, 1) + "ay"));
        }

        public static string TitleCase(string title, string minorWords = "")
        {
            if (string.IsNullOrEmpty(minorWords)) return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title);
            return string.Join(" ", title.ToLower().Split(' ').Select((s, i) =>
                i == 0 | !minorWords.ToLower().Split(' ').Contains(s)
                    ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s)
                    : s));
        }

        public static int CountSmileys(string[] smileys)
        {
            return smileys.Count(s => new Regex("(:|;)(-|~)?(\\)|D)").IsMatch(s));
        }

        public static bool Alphanumeric(string str)
        {
            return new Regex("^([a-zA-Z0-9])+$").IsMatch(str);
        }

        public static string GenerateBC(string url, string separator)
        {
            var urlArrays = url.Replace("://", string.Empty).Split('/').Where(s => !(Regex.IsMatch(s, "^[#|?]+") | Regex.IsMatch(s, "^index.\\S+")) & !string.IsNullOrEmpty(s)).ToArray();
            if (urlArrays.Length == 0 | urlArrays.Length == 1) return "<span class=\"active\">HOME</span>";
            
            var listStr = new List<string> {"<a href=\"/\">HOME</a>"};
            for (var i = 1; i < urlArrays.Length; i++)
            {
                if (i == urlArrays.Length - 1)
                {
                    var str = urlArrays[i].Replace('?', '.').Replace('#', '.').Split('.')[0];
                    str = str.Length > 30 ? GetShortenStr(str) : str;
                    listStr.Add(string.Format("<span class=\"active\">{0}</span>", str.Replace('-', ' ').ToUpper()));
                }
                else
                {
                    var originStr = string.Join("/", urlArrays.Where((s, idx) => idx >= 1 & idx <=i));
                    var str = urlArrays[i].Length > 30 ? GetShortenStr(urlArrays[i]) : urlArrays[i];
                    listStr.Add(string.Format("<a href=\"/{0}/\">{1}</a>", originStr, str.Replace('-', ' ').ToUpper()));
                }
            }

            return string.Join(separator, listStr);
        }

        public static string GetShortenStr(string str)
        {
            var shortenElements = new[] {"the", "of", "in", "from", "by", "with", "and", "or", "for", "to", "at", "a"};
            var strArray = str.Split('-');
            return strArray.Where(s => !shortenElements.Contains(s)).Aggregate(string.Empty, (current, s) => current + s[0]);
        }
    }

    public class Accumul
    {
        public static String Accum(string s)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                string.Join("-", s.Select((x, i) => new string(char.ToLower(x), i + 1))));
        }
    }

    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0) return new[] { 0.0d };

            var tribonacciArray = new List<double>();
            tribonacciArray.AddRange(n < 3 ? signature.Where((d, i) => i < n) : signature);

            for (var i = 3; i < n; i++)
            {
                var calcValue = tribonacciArray.Where((d, idx) => (idx < i) & (idx >= i - 3)).Sum();
                tribonacciArray.Add(calcValue);
            }

            return tribonacciArray.ToArray();
        }
    }

    public class DnaStrand
    {
        //public static string MakeComplement(string dna)
        //{
        //    return new string(GetDna(dna).ToArray());
        //}

        //public static IEnumerable<char> GetDna(string dna)
        //{
        //    foreach (var c in dna)
        //    {
        //        switch (c)
        //        {
        //            case 'A':
        //                yield return 'T';
        //                break;
        //            case 'T':
        //                yield return 'A';
        //                break;
        //            case 'C':
        //                yield return 'G';
        //                break;
        //            case 'G':
        //                yield return 'C';
        //                break;
        //        }
        //    }
        //}

        public static string MakeComplement(string dna)
        {
            return GetDna(dna).Cast<object>().Aggregate(string.Empty, (current, s) => current + s);
        }

        public static IEnumerable GetDna(string dna)
        {
            foreach (var c in dna)
            {
                switch (c)
                {
                    case 'A':
                        yield return 'T';
                        break;
                    case 'T':
                        yield return 'A';
                        break;
                    case 'C':
                        yield return 'G';
                        break;
                    case 'G':
                        yield return 'C';
                        break;
                }
            }
        }
    }

    public class Arge
    {

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            return p0 + (int)(p0 * (percent / 100)) + aug >= p ?
                1 :
                NbYear(p0 + (int)(p0 * (percent / 100)) + aug, percent, aug, p) + 1;
        }
    }

    public class Number
    {
        public int DigitalRoot(long n)
        {
            //n = n.ToString().Select(c => Convert.ToInt32(c.ToString())).Sum();
            //return (int) (n < 10 ? n : DigitalRoot(n));
            return (int)(1 + (n - 1) % 9);
        }
    }

    public class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            //return array1.Where(delegate (string s, int i)
            //{
            //    foreach (var s2 in array2)
            //    {
            //        var s2Len = s2.Length;
            //        var replaceLen = s2.Replace(s, string.Empty).Length;
            //        if (s2Len != replaceLen)
            //            return true;
            //    }
            //    return false;
            //}).OrderBy(s => s).ToArray();

            return array1.Distinct().Where(s1 => array2.Any(s2 => s2.Contains(s1))).OrderBy(s => s).ToArray();
        }
    }

    public class Sudoku
    {
        public static string DoneOrNot(int[][] board)
        {
            var finished = true;
            for (int i = 0; i < board.Length; i++)
            {
                var sortRow = board[i].OrderBy(data => data);
                var sortColumn = board.Select(t => t[i]).ToList().OrderBy(data => data);

                if (!sortRow.SequenceEqual(Enumerable.Range(1, 9)) |
                    !sortColumn.SequenceEqual(Enumerable.Range(1, 9)))
                {
                    finished = false;
                    break;
                }
            }

            if (finished)
            {
                for (int i = 0; i < board.Length; i+=3)
                {
                    for (int j = 0; j < board.Length; j+=3)
                    {
                        var region = new List<int>();
                        region.AddRange(board[i].Skip(j).Take(3));
                        region.AddRange(board[i+1].Skip(j).Take(3));
                        region.AddRange(board[i+2].Skip(j).Take(3));

                        var sortRegion = region.OrderBy(data => data);
                        if (!sortRegion.SequenceEqual(Enumerable.Range(1, 9)))
                        {
                            finished = false;
                            break;
                        }
                    }
                }
            }
            
            return finished ? "Finished!" : "Try again!";
        }
    }

    public class SumSquaredDivisors
    {
        public class Squared
        {
            public long Num { get; set; }
            public long SquaredValue { get; set; }

            public override string ToString()
            {
                return string.Format("[{0}, {1}]", Num, SquaredValue);
            }
        }

        public class SquaredList : List<Squared>
        {
            public override string ToString()
            {
                return string.Format("[{0}]", string.Join(", ", this));
            }
        }

        public static string listSquared(long m, long n)
        {
            var listSquared = new SquaredList();
            for (var i = m; i < n; i++)
            {
                var squaredValue = GetDivisors((int)i).Select(j => Math.Pow(j, 2)).Sum();
                var sqrtSquaredValue = Math.Sqrt(squaredValue);
                if (sqrtSquaredValue.Equals(Math.Floor(sqrtSquaredValue)))
                {
                    listSquared.Add(new Squared {Num = i, SquaredValue = (long) squaredValue});
                }
            }
            
            return listSquared.ToString();
        }

        public static IEnumerable<int> GetDivisors(int n)
        {
            return from a in Enumerable.Range(1, n)
                where n % a == 0
                select a;
        }
    }

    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            var ts = TimeSpan.FromSeconds(seconds);

            return ts.TotalDays >= 1
                ? string.Format("{0}:{1:mm\':\'ss}", (int) ts.TotalHours, ts)
                : ts.ToString("hh':'mm':'ss");
        }
    }

    public class ToSmallest
    {
        public static long[] Smallest(long n)
        {
            var smallestN = n;
            var smallestI = 0;
            var smallestj = 0;

            for (int i = 0; i < n.ToString().Length; i++)
            {
                for (int j = 0; j < n.ToString().Length; j++)
                {
                    var switchNum = GetSwithNumber(n.ToString(), i, j);
                    if (switchNum < smallestN || (switchNum == smallestN) & i < smallestI)
                    {
                        smallestN = switchNum;
                        smallestI = i;
                        smallestj = j;
                    }
                }
            }
            return new[] { smallestN, smallestI, smallestj };
        }

        public static long GetSwithNumber(string num, int i, int j)
        {
            var numStr = num.Remove(i, 1).Insert(j, num[i].ToString());
            return Convert.ToInt64(numStr);
        }
    }
}
