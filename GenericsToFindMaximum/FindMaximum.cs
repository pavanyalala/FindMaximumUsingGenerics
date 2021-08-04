using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsToFindMaximum
{
    public class FindMaximum
    {
        /// <summary>
        /// Checks maximum of three numbers and returns Largest value
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <returns></returns>
        public static int MaxInteger(int value1, int value2, int value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                Console.WriteLine("value1 is Largest : " + value1);
                return value1;
            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
            {
                Console.WriteLine("Value2 is Largest : " + value2);
                return value2;
            }
            if (value3.CompareTo(value2) > 0 && value3.CompareTo(value1) > 0)
            {
                Console.WriteLine("Value3 is Largest : " + value3);
                return value3;   
            }
            throw new Exception("Three Values Are Equal");
        }
        /// <summary>
        /// Checks maximum of three numbers and returns Largest value
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <returns></returns>
        public static float MaxFloat(float value1, float value2, float value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                Console.WriteLine("value1 is Largest : " + value1);
                return value1;
            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
            {
                Console.WriteLine("Value2 is Largest : " + value2);
                return value2;
            }
            if (value3.CompareTo(value2) > 0 && value3.CompareTo(value1) > 0)
            {
                Console.WriteLine("Value3 is Largest : " + value3);
                return value3;
            }
            throw new Exception("Three Values Are Equal");
        }
        /// <summary>
        /// Checks maximum of three numbers and returns Largest value
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <returns></returns>
        public static string MaxString(string value1, string value2, string value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                Console.WriteLine("value1 is Largest : " + value1);
                return value1;
            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
            {
                Console.WriteLine("Value2 is Largest : " + value2);
                return value2;
            }
            if (value3.CompareTo(value2) > 0 && value3.CompareTo(value1) > 0)
            {
                Console.WriteLine("Value3 is Largest : " + value3);
                return value3;
            }
            throw new Exception("Three Values Are Equal");
        }
    }
}
    

