namespace FunctionalFactorial {
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class SampleTests
    {
        [Test]
        public void Factorial1()
        {
            var retFunc = Factorial.GetFactorialFunction();
            Assert.AreEqual(1, retFunc(1));
        }
    
        [Test]
        public void Factorial2()
        {
            var retFunc = Factorial.GetFactorialFunction();
            Assert.AreEqual(2, retFunc(2));
        }
        [Test]
        public void Factorial3()
        {
            var retFunc = Factorial.GetFactorialFunction();
            Assert.AreEqual(6, retFunc(3));
        }
    
        [Test]
        public void Factorial4()
        {
            var retFunc = Factorial.GetFactorialFunction();
            Assert.AreEqual(24, retFunc(4));
        }
  
        [Test]
        public void Factorial5()
        {
            var retFunc = Factorial.GetFactorialFunction();
            Assert.AreEqual(120, retFunc(5));
        }
    
        [Test]
        public void Factorial6()
        {
            var retFunc = Factorial.GetFactorialFunction();
            Assert.AreEqual(720, retFunc(6));
        }
    }
}