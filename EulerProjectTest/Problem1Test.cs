using System.Collections.Generic;
using EulerProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EulerProjectTest
{
    
    
    /// <summary>
    ///This is a test class for Problem1Test and is intended
    ///to contain all Problem1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Problem1Test
    {
        /// <summary>
        ///A test for SumMultiples
        ///</summary>
        [TestMethod()]
        public void SumMultiplesTest_Below10()
        {
            var multiplesOf = new List<int>();
            multiplesOf.Add(3);
            multiplesOf.Add(5);

            int below = 10;

            int expected = 23;
            int actual;
            actual = Problem1.AttemptThree_SumMultiples(multiplesOf, below);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumMultiplesTest_Below1000()
        {
            var multiplesOf = new List<int>();
            multiplesOf.Add(3);
            multiplesOf.Add(5);

            int below = 1000;

            int expected = 233168;
            int actual = Problem1.AttemptThree_SumMultiples(multiplesOf, below);
            Assert.AreEqual(expected, actual);
        }
    }
}
