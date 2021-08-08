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
            maxInt.PrintMax();

            float[] floatValues = {11.08f, 45.08f, 08.11f, 11.80f};
            FindMaximum<float> maxFloat = new FindMaximum<float>(floatValues);
            maxFloat.MaxValue(floatValues);
            maxFloat.PrintMax();

            string[] stringValues = { "Oneplus", "Apple", "Vivo", "Oppo" };
            FindMaximum<string> maxString = new FindMaximum<string>(stringValues);
            maxString.MaxValue(stringValues);
            maxString.PrintMax();


        }
    }
}
