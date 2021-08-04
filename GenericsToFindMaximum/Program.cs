using System;

namespace GenericsToFindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum by using Generics");
            int integerValue = FindMaximum<int>.FindMax(1108, 4508, 0811);
            Console.WriteLine("Maximum value : " + integerValue);
            float floatValue = FindMaximum<float>.FindMax(11.08f, 45.08f, 08.11f);
            Console.WriteLine("Maximum value : " + floatValue);
            string stringValue = FindMaximum<string>.FindMax("Apple", "Vivo", "Oppo");
            Console.WriteLine("Maximum value : " + stringValue); 
            
        }
    }
}
