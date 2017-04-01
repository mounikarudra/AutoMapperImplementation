using System;
namespace EqualsMethodsFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            Program objP1 = new Program();
            Program objP2 = new Program();
            objP1 = objP2;

            Console.WriteLine(objP1.EqualsVirtual(objP2));
            Console.WriteLine(ObjectClass.EqualsStatic(objP1,objP2));
            Console.WriteLine(ObjectClass.EqualsReference(objP1,objP2));
        }

    }
}
