using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace KataTest
{
    public class Kata
    {
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
}
