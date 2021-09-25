using System;
using System.Linq;

namespace lab2
{
    class RangeArray
    {
        private int bottom_border;
        private int top_border;
        private int[] arr;

        // constructors
        public RangeArray()
        {
            this.bottom_border = 0;
            this.top_border = 0;
            this.arr = new int[0]{};
        }

        public RangeArray(int bottom_br, int top_br)
        {
            this.bottom_border = bottom_br;
            this.top_border = top_br;
        }

        // methods
        public void Read()
        {
            Console.WriteLine("Enter the values of array splitting by comma (,): ");
            string temp = Console.ReadLine();
            this.arr = Array.ConvertAll(temp.Split(','), int.Parse);
        }

        public void Write()
        {
            Console.WriteLine("Current array: [{0}]", string.Join(", ", this.arr));
        }

        public int MaxRangeArray()
        {
            return this.arr.Max();
        }

        public int Positive()
        {
            int counter = 0;

            foreach (int val in this.arr)
            {
                if (val > 0)
                    counter++;
            }

            return counter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RangeArray test = new RangeArray();
            test.Read();
            test.Write();
            Console.WriteLine("Max number is {0}", test.MaxRangeArray());
            Console.WriteLine("Amount of positive nums is {0}", test.Positive());

            Console.Read();
        }
    }
}
