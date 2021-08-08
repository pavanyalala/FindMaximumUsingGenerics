using System;

namespace GenericsToFindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum by using Generics");
            int[] intValues = { 1108, 4508, 0811, 1180 };
            FindMaximum<int> maxInt = new FindMaximum<int>(intValues);
            maxInt.MaxValue(intValues);

            float[] floatValues = {11.08f, 45.08f, 08.11f, 11.80f};
            FindMaximum<float> findMaxFloat = new FindMaximum<float>(floatValues);
            findMaxFloat.MaxValue(floatValues);

            string[] stringValues = { "Oneplus", "Apple", "Vivo", "Oppo" };
            FindMaximum<string> findMaxString = new FindMaximum<string>(stringValues);
            findMaxString.MaxValue(stringValues);



        }
    }
}
