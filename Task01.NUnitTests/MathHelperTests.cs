using System;
using Task01.Logic;
using NUnit.Framework;

namespace Task01.NUnitTests
{
    [TestFixture]
    public class MathHelperTests
    {
        [TestCase(-28, 56, ExpectedResult = -28)]
        [TestCase(-16,256,ExpectedResult = -16)]
        [TestCase(int.MaxValue,int.MaxValue,ExpectedResult = int.MaxValue)]
        [TestCase(100,99,ExpectedResult = 1)]
        [TestCase(100,10,ExpectedResult = 10)]
        public int EuclideanGCD_Test(int a, int b)
        {
                return MathHelper.GCD(MathHelper.AlgorithmGcd.Euclidean,a, b);
        }

       /* [TestCase(0,0)]
        public void EuclideanGCD_ExcTests(int a, int b)
        {
            var exp = Assert.Throws<ArgumentException>(() => MathHelper.EuclideanGCD(a, b));
            Assert.That(exp.Message, Is.EqualTo("at least one number must be non zero"));
        }*/
    }
}
