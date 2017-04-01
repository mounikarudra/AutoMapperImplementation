using System;

namespace IsAndAsFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            Derived derivedObj = new Derived();
            DerivedOfDerived derivedOfDerivedObj = new DerivedOfDerived();
            IsAndAsFunctionality fobj = new IsAndAsFunctionality();
            bool status = fobj.IsFunctionality(derivedObj, derivedOfDerivedObj.GetType());
            object convertedObject = fobj.AsFunctionality<DerivedOfDerived>(derivedObj, derivedOfDerivedObj.GetType());

            Console.WriteLine(status);
            Console.WriteLine(convertedObject);

        }
    }
}
