using System;
using System.Linq;

namespace lab2
{
    class RangeArray
    {
        private int bottom_border;
        private int top_border;
        private int length;
        private int[] arr;
        private int[] indexes;
        private int[] def_indexes;

        // property
        public int Length 
        {
            get => this.length;
        }

        // constructors
        public RangeArray()
        {
            this.bottom_border = 0;
            this.top_border = 0;
            this.length = 0;
            this.arr = new int[0]{};
            this.indexes = new int[0]{};
        }

        public RangeArray(int bottom_br, int top_br)
        {
            this.bottom_border = bottom_br;
            this.top_border = top_br;
            this.length = (this.top_border - this.bottom_border) + 1;
            this.arr = new int[this.length];
            this.indexes = this.def_indexes = new int[this.length];
            this.indexes = Enumerable.Range(this.bottom_border, this.length).ToArray();
            this.def_indexes = Enumerable.Range(0, this.length).ToArray();
        }

        // methods
        public void Write()
        {
            Console.WriteLine($"Enter the values of array (length = {this.length}) splitting by comma (,): ");
            string temp = Console.ReadLine();
            this.arr = Array.ConvertAll(temp.Split(','), int.Parse);
        }

        public void Read()
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

        public void Add(int num)
        {
            Array.Resize(ref this.arr, this.arr.Length + 1);
            this.arr[this.arr.Length - 1] = num;
        }

        public void Remove(int del_num)
        {
            this.arr = this.arr.Where(num => num != del_num).ToArray();
        }

        public int Includes(int num)
        {
            int counter = 0;

            foreach (int val in this.arr)
            {
                if (val == num)
                    counter++;
            }

            return counter;
        }

        // overloading operators
        public static RangeArray operator +(RangeArray x, RangeArray y)
        {
            RangeArray res = new RangeArray();

            for (int i = 0; i < x.arr.Length; i++)
            {
                Array.Resize(ref res.arr, res.arr.Length + 1);
                res.arr[i] = x.arr[i] + y.arr[i];
            }


            return res;
        }

        public static RangeArray operator ++(RangeArray x)
        {
            RangeArray res = new RangeArray();

            for (int i = 0; i < x.arr.Length; i++)
            {
                x.arr[i]++;
            }

            return res;
        }

        // Indexer
        public int this[int index]
        {
            get => index >= 0 ? this.arr[index] : FindIndex(index);
        }

        private int FindIndex(int index)
        {

            for (int j = 0; j < this.indexes.Length; j++)
            {
                if (index == this.indexes[j])
                {
                    return this.arr[def_indexes[j]];
                }
            }

            throw new ArgumentOutOfRangeException(
                nameof(index),
                $"Index {index} is not supported.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RangeArray arr = new RangeArray(-1, 2);
            arr.Write();
            arr.Read();
            Console.WriteLine(arr[-2]);
            Console.WriteLine(arr[2]);

            Console.Read();
        }
    }
}
