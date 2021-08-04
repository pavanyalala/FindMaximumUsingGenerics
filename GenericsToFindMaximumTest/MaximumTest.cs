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
        /// <summary>
        /// Test case : 1.3
        /// </summary>
        [Test]
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            int actualMax = FindMaximum.MaxInteger(0811, 1108, 4508);
            Assert.AreEqual(4508, actualMax);
        }
        /// <summary>
        /// Test case : 2.1
        /// </summary>
        [Test]
        public void GivenMaxFloatFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            float actualMax = FindMaximum.MaxFloat(45.08f, 11.08f, 08.11f);
            Assert.AreEqual(45.08f, actualMax);
        }
        /// <summary>
        /// Test case : 2.2
        /// </summary>
        [Test]
        public void GivenMaxFloatSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            float actualMax = FindMaximum.MaxFloat(11.08f, 45.08f, 08.11f);
            Assert.AreEqual(45.08f, actualMax);
        }
        /// <summary>
        /// Test case : 2.3
        /// </summary>
        [Test]
        public void GivenMaxFloatThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            float actualMax = FindMaximum.MaxFloat(08.11f, 11.08f, 45.08f);
            Assert.AreEqual(45.08f, actualMax);
        }
    }
}