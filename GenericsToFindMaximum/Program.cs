using System;

namespace GenericsToFindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum by using Generics");
            FindMaximum.MaxInteger(1108,4508,0811);
            FindMaximum.MaxFloat(11.08f,45.08f,08.11f);
            FindMaximum.MaxString("Apple", "Vivo", "Oneplus");
            
        }
    }
}
