using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsToFindMaximum
{
    /// <summary>
    ///Class to find maximum value 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FindMaximum<T> where T : IComparable
    {
        public T[] value;
        public FindMaximum(T[] value)
        {
            this.value = value;
        }
        /// <summary>
        /// array to sort values
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        /// <summary>
        /// methiod to find max value 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        /// <summary>
        /// Maximum Method to Find Maximim Value
        /// </summary>
        public void PrintMax()
        {
            var print = MaxValue(this.value);
            Console.WriteLine("Maximum Value is: " + print);
        }

    }
}
    

