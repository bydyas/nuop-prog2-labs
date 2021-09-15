using System;

namespace lab2
{
    public class BitString
    {
        private int _length;
        private int[] _vars;

        public BitString() {}
        public BitString(int bit_length)
        {
            Length = bit_length;
            Vars = Generate_Random_Bit_Vars(_length);
        }
        public BitString(int bit_length, int[] bit_values)
        {
            Length = bit_length;
            Vars = bit_values;
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public int[] Vars
        {
            get { return _vars; }
            set { _vars = value; }
        }

        // generating a random array of bit variables (0,1) when constructor has only one argument;
        public int[] Generate_Random_Bit_Vars(int len)
        {
            int[] bit_store = new int[len];
            Random rnd = new Random();

            for (int i = 0; i < len; i++)
            {
                int bit_value = rnd.Next(0, 2);
                bit_store[i] = bit_value;
            }

            return bit_store;
        }

        // overloading methods


        // console input - output methods
        public void ReadBitString() {
            string temp = Console.ReadLine();
            _vars = Array.ConvertAll(temp.Split(' '), int.Parse);
        }

        public void WriteBitString() {
            //Console.WriteLine(_vars);
            Console.WriteLine("{0}", string.Join(" ", _vars));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // testing constructors
            BitString b_str = new BitString();
            b_str.ReadBitString();
            b_str.WriteBitString();
        }
    }
}
