using NUnit.Framework;
using GenericsToFindMaximumTest;
using GenericsToFindMaximum;

namespace GenericsToFindMaximumTest
{
    public class Tests
    {
        /// <summary>
        /// Test case : 1.1
        /// </summary>
        [Test]
        public void GivenMaxNumFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            int actualMax = FindMaximum.MaxInteger(4508, 1108, 0811);
            Assert.AreEqual(4508, actualMax);
        }
        /// <summary>
        /// Test case : 1.2
        /// </summary>
        [Test]
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            int actualMax = FindMaximum.MaxInteger(1108, 4508, 0811);
            Assert.AreEqual(4508, actualMax);
        }
        [Test]
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            int actualMax = FindMaximum.MaxInteger(0811, 1108, 4508);
            Assert.AreEqual(4508, actualMax);
        }
    }
}