using System;

namespace AutoMapperImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new Source { a = 10, A = "test", B = 100500 };
            var Destination = AutoMapper.Map<Destination>(source);

            Console.WriteLine("source type is {0}", source.GetType());
            Console.WriteLine("Destination type is {0}", Destination.GetType());
            Console.WriteLine("source.A={0} source.B={1}", source.A, source.B);
            Console.WriteLine("Destination.A={0} Destination.B={1} Destination.C={2} Destination.a={3}",
                                 Destination.A, Destination.B, Destination.C, Destination.a);
        }
    }
}
