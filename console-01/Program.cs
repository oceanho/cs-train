using System;

namespace console_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=20;
            Console.WriteLine(String.Format("Raw value:  a={0}, b={1}",a,b));
            a ^= b;
            b ^= a;
            a ^= b;
            Console.WriteLine(String.Format("Transfer Result:  a={0}, b={1}",a,b));
        }
    }
}
