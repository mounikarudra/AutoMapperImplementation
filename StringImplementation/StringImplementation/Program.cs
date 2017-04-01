using System;

namespace StringImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ch0 = { 'm', 'o', 'u', 'n', 'i' };
            String str0 = new String(ch0);
            String str1 = "ka";
            str0=String.Concat(str0, str1);
            Console.WriteLine(str0);
            Console.WriteLine(str1);
        }
    }
}
