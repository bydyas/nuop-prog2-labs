using System;

namespace lab3
{
    internal class RangeMatrix
    {
        private int bot_row_i;
        private int top_row_i;
        private int bot_col_i;
        private int top_col_i;
        private int[,] matrix;
        int len1, len2;


        public int Row => this.len1;
        public int Col => this.len2;


        public RangeMatrix() { }

        public RangeMatrix(int size)
        {
            this.bot_row_i = 0;
            this.top_row_i = size - 1;
            this.bot_col_i = 0;
            this.top_col_i = size - 1;

            this.len1 = size;
            this.len2 = size;

            this.matrix = new int[size, size];
            Random rnd = new Random();

            for (int i = this.bot_row_i; i < this.len1; i++) // row
            {
                for (int j = this.bot_col_i; j < this.len2; j++) // col
                {
                    this.matrix[i, j] = rnd.Next(10, 99);
                }
            }
        }

        public RangeMatrix(int b_row_i, int t_row_i, int b_col_i, int t_col_i)
        {
            this.bot_row_i = b_row_i;
            this.top_row_i = t_row_i;
            this.bot_col_i = b_col_i;
            this.top_col_i = t_col_i;

            if (this.bot_col_i > this.top_col_i || this.bot_row_i > this.top_row_i)
            {
                RangeError error = new RangeError();
                Console.WriteLine(error.Message);
            } else
            {
                this.len1 = this.top_row_i - this.bot_row_i + 2;
                this.len2 = this.top_col_i - this.bot_col_i + 2;
            }

            this.matrix = new int[len1, len2];
            Random rnd = new Random();

            for (int i = this.bot_row_i; i < this.len1; i++) // row
            {
                for (int j = this.bot_col_i; j < this.len2; j++) // col
                {
                    this.matrix[i, j] = rnd.Next(10, 99);
                }
            }
        }

        
        public void Read()
        {
            for (int i = this.bot_row_i; i < len1; i++)
            {

                for (int j = this.bot_col_i; j < len2; j++)
                {
                    Console.Write(" " + this.matrix[i, j]);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("\n");
        }
    }
}
