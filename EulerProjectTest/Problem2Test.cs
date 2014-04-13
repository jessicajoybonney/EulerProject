using EulerProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerProjectTest
{
    [TestClass()]
    public class Problem2Test
    {
        /// <summary>
        ///A test for SumEvenFibonacciNumbers
        ///</summary>
        [TestMethod()]
        public void SumEvenFibonacciNumbers_BelowHundred_Test()
        {
            int below = 100;
            int actual = Problem2.SumEvenFibonacciNumbers_AttemptTwo(below);

            int expected = 44;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumEvenFibonacciNumbers_BelowTen_Test()
        {
            int below = 10;
            int actual = Problem2.SumEvenFibonacciNumbers_AttemptTwo(below);

            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SumEvenFibonacciNumbers
        ///</summary>
        [TestMethod()]
        public void SumEvenFibonacciNumbers_BelowFourMil_Test()
        {
            int below = 4000000;//4,000,000;
            int actual = Problem2.SumEvenFibonacciNumbers_AttemptTwo(below);

            int expected = 10;
            Assert.AreEqual(expected, actual);
        }
    }
}
