namespace FunctionalFactorial {
    using System;
    public class Factorial
    {
        public static Func<int, int> GetFactorialFunction()
        {
            return i =>
            {
                if (i <= 1) return 1;
                return GetFactorialFunction().Invoke(i - 1) * i;
            };
        }
    }
}