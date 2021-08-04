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
            int actualMax = FindMaximum.MaxInteger(4508, 1108, 0810);
            Assert.AreEqual(4508, actualMax);
        }
        [Test]
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSeconf()
        {
            int actualMax = FindMaximum.MaxInteger(1108, 4508, 0810);
            Assert.AreEqual(4508, actualMax);
        }
    }
}