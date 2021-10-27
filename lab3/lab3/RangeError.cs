using System;

namespace lab3
{
    internal class RangeError : Exception
    {
        public RangeError() : base() { }
        public RangeError(string msg) : base() { }
        public RangeError(string msg, Exception expt) : base() { }

    }
}
