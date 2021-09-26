﻿using System;
using System.Linq;

namespace lab2
{
    class RangeArray
    {
        private int bottom_border;
        private int top_border;
        private int[] arr;

        // property
        public int Length
        {
            get => this.arr.Length;
        }

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
            this.arr = new int[2] { this.bottom_border, this.top_border };
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

        // indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= this.arr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return this.arr[index];
            }

            set
            {
                if (index < 0 || index >= this.arr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                this.arr[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RangeArray x = new RangeArray();
            x.Read();
            x.Write();

            // RangeArray y = new RangeArray();
            // y.Read();
            // RangeArray res = new RangeArray();
            // res = x + y;
            // res.Write();

            // x++.Write();
            // x.Add(5);
            // x.Remove(4);

            // Console.WriteLine(x.Length);
            // Console.WriteLine("Max number is {0}", x.MaxRangeArray());
            // Console.WriteLine("Amount of positive nums is {0}", x.Positive());
            // Console.WriteLine("The similarity is {0}", x.Includes(2));

            Console.Read();
        }
    }
}
