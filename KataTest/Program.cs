using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace KataTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Branch Test !!!!!
            // Hello World ~!
            // Push Test~!
            Test();
        }

        public static void Test()
        {
            var dic = new Dictionary<int, object>();

            foreach (var value in Enumerable.Range(0, 10000))
            {
                dic.Add(value, value + 1);
            }

            ThreadPool.QueueUserWorkItem(delegate
            {
                TestDictionary(dic);
                //TestDictionary(dic.ToDictionary(pair => pair.Key, pair => pair.Value));
            });

            ThreadPool.QueueUserWorkItem(delegate
            {
                TestDictionary1(dic);
                //TestDictionary1(dic.ToDictionary(pair => pair.Key, pair => pair.Value));
            });

            Console.ReadLine();
        }

        public static void TestDictionary1(Dictionary<int, object> dic)
        {
            dic.Clear();
            foreach (var value in Enumerable.Range(0, 100))
            {
                dic.Add(value, value + 1);
            }
        }

        public static void TestDictionary(Dictionary<int, object> dic)
        {
            for (int i = 0; i < 100; i++)
            {
                foreach (var keyValuePair in dic.Keys)
                {
                    var tmp = keyValuePair;
                    Console.WriteLine(tmp);
                }
            }
        }
    }
}
