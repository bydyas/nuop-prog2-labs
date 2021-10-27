using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeMatrix m = new RangeMatrix(2, 5, 2, 5);
            m.Read();

            RangeMatrix n = new RangeMatrix(2);
            n.Read();

            Console.ReadKey();
        }
    }
}
