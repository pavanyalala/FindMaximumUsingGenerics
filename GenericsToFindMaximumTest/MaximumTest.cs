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
            int actualValue = FindMaximum<int>.FindMax(4508, 1108, 0811);
            Assert.AreEqual(4508, actualValue);
        }
        /// <summary>
        /// Test case : 1.2
        /// </summary>
        [Test]
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            int actualMax = FindMaximum<int>.FindMax(1108, 4508, 0811);
            Assert.AreEqual(4508, actualMax);
        }
        /// <summary>
        /// Test case : 1.3
        /// </summary>
        [Test]
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            int actualMax = FindMaximum<int>.FindMax(0811, 1108, 4508);
            Assert.AreEqual(4508, actualMax);
        }
        /// <summary>
        /// Test case : 2.1
        /// </summary>
        [Test]
        public void GivenMaxFloatFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            float actualMax = FindMaximum<float>.FindMax(45.08f, 11.08f, 08.11f);
            Assert.AreEqual(45.08f, actualMax);
        }
        /// <summary>
        /// Test case : 2.2
        /// </summary>
        [Test]
        public void GivenMaxFloatSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            float actualMax = FindMaximum<float>.FindMax(11.08f, 45.08f, 08.11f);
            Assert.AreEqual(45.08f, actualMax);
        }
        /// <summary>
        /// Test case : 2.3
        /// </summary>
        [Test]
        public void GivenMaxFloatThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            float actualMax = FindMaximum<float>.FindMax(11.08f, 08.11f, 45.08f);
            Assert.AreEqual(45.08f, actualMax);
        }
        /// <summary>
        /// Test case : 3.1
        /// </summary>
        [Test]
        public void GivenMaxStringFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            string actualMax = FindMaximum.MaxString("Vivo", "Oppo", "Apple");
            Assert.AreEqual("Vivo", actualMax);
        }
        /// <summary>
        /// Test case : 3.2
        /// </summary>
        [Test]
        public void GivenMaxStringSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            string actualMax = FindMaximum.MaxString("Apple", "Vivo", "Oppo");
            Assert.AreEqual("Vivo", actualMax);
        }
        /// <summary>
        /// Test case : 3.3
        /// </summary>
        [Test]
        public void GivenMaxStringThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            string actualMax = FindMaximum.MaxString("Apple", "Oppo", "Vivo");
            Assert.AreEqual("Vivo", actualMax);
        }
    }
}