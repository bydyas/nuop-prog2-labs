using System;

namespace lab1
{
    class Complex
    {
        private double real_part;
        private double imaginary_part;

        // constructors
        public Complex()
        {
            this.real_part = 0;
            this.imaginary_part = 0;
        }

        public Complex(int real_prt, int imaginary_prt)
        {
            this.real_part = real_prt;
            this.imaginary_part = imaginary_prt;
        }

        // overloading operators
        public static Complex operator +(Complex x, Complex y)
        {
            Complex res = new Complex();
            res.real_part = x.real_part + y.real_part;
            res.imaginary_part = x.imaginary_part + y.imaginary_part;

            return res;
        }

        public static Complex operator -(Complex x, Complex y)
        {
            Complex res = new Complex();
            res.real_part = x.real_part - y.real_part;
            res.imaginary_part = x.imaginary_part - y.imaginary_part;

            return res;
        }

        public static Complex operator *(Complex x, Complex y)
        {
            Complex res = new Complex();
            res.real_part = x.real_part * y.real_part - (x.imaginary_part * y.imaginary_part);
            res.imaginary_part = x.imaginary_part * y.imaginary_part + (x.real_part * y.real_part);

            return res;
        }

        public static Complex operator /(Complex x, Complex y)
        {
            Complex res = new Complex();
            res.real_part = (x.real_part * y.real_part + x.imaginary_part * y.imaginary_part) / (Math.Pow(y.real_part, 2) + Math.Pow(y.imaginary_part, 2));
            res.imaginary_part = (x.imaginary_part * y.real_part - x.real_part * y.imaginary_part) / (Math.Pow(y.real_part, 2) + Math.Pow(y.imaginary_part, 2));

            return res;
        }

        public static Complex operator ++(Complex x)
        {
            Complex res = new Complex();
            res.real_part = ++x.real_part;

            return res;
        }

        public static Complex operator --(Complex x)
        {
            Complex res = new Complex();
            res.real_part = --x.real_part;

            return res;
        }

        public static bool operator >(Complex x, Complex y)
        {
            if (x.Abs() > y.Abs())
                return true;
            else
                return false;
        }

        public static bool operator <(Complex x, Complex y)
        {
            if (x.Abs() < y.Abs())
                return true;
            else
                return false;
        }

        // methods
        public void Read()
        {
            Console.WriteLine("Enter the value of complex real part: ");
            this.real_part = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of complex imaginary part: ");
            this.imaginary_part = Convert.ToInt32(Console.ReadLine());
        }

        public void Write()
        {
            Console.WriteLine("({0}, {1})", this.real_part, this.imaginary_part);
        }

        public double Abs()
        {
            return Math.Sqrt(this.real_part + this.imaginary_part);
        }

        public double Argument()
        {
            // complex argument
            return Math.Atan2(this.imaginary_part, this.real_part);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex num_1 = new Complex();
            num_1.Read();
            num_1.Write();
            Complex num_2 = new Complex();
            num_2.Read();
            num_2.Write();

            Complex res = new Complex();
            res = num_1 + num_2;
            res.Write();

            Console.Read();
        }
    }
}
