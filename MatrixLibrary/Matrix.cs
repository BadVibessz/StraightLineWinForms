using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace matr_try2
{
    public class Matrix
    {
        protected readonly double[,] values;

        public Matrix(int r, int c)
        {
            if (r <= 0 || c <= 0) throw new Exception("Wrong argument");
            else
                this.values = new double[r, c];
        }

        public Matrix(double[,] ar)
        {
            int r = ar.GetLength(0);
            int c = ar.Length / ar.GetLength(0);
            this.values = new double[r, c];

            for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                this.values[i, j] = ar[i, j];
        }

        public Matrix(Matrix other)
        {
            this.values = new double[other.Row, other.Col];
            for (int i = 0; i < other.Row; i++)
            for (int j = 0; j < other.Col; j++)
                this.values[i, j] = other.values[i, j];
        }


        public int Row
        {
            set { }
            get { return this.values.GetLength(0); }
        }

        public int Col
        {
            set { }
            get { return this.values.Length / values.GetLength(0); }
        }

        public double this[int i, int j]
        {
            get => this.values[i, j];
        }

        public int Rang
        {
            get
            {
                var copy = new Matrix(this);
                copy.ToTriangularMatrix();

                int count = 0;
                for (int i = 0; i < copy.Row; i++)
                {
                    int temp = 0;
                    for (int j = 0; j < copy.Col; j++)
                        if (copy[i, j] != 0) temp++;
                    if (temp != 0) count++;
                }

                return count;
            }
        }


        private void SwapRows(int i, int j)
        {
            for (int k = 0; k < Col; k++)
                (values[i, k], values[j, k]) = (values[j, k], values[i, k]);
        }

        public void ToTriangularMatrix()
        {
            for (int k = 0; k < Row; k++)
            {
                // Initialize maximum value and index for pivot
                int i_max = k;
                int v_max = (int)values[i_max, k];

                /* find greater amplitude for pivot if any */
                for (int i = k + 1; i < Row; i++)
                {
                    if (Math.Abs(values[i, k]) > v_max)
                    {
                        v_max = (int)values[i, k];
                        i_max = i;
                    }

                    /* If a principal diagonal element  is zero,
                    *  it denotes that matrix is singular, and
                    *  will lead to a division-by-zero later. */
                    if (values[k, i_max] == 0)
                        throw new Exception("Matrix is singular"); // Matrix is singular

                    /* Swap the greatest value row with
                       current row
                    */
                    if (i_max != k)
                        SwapRows(k, i_max);

                    for (int l = k + 1; l < Row; l++)
                    {
                        /* factor f to set current row kth element
                        *  to 0, and subsequently remaining kth
                        *  column to 0 */
                        double f = values[l, k] / values[k, k];

                        /* subtract fth multiple of corresponding
                           kth row element*/
                        for (int j = k + 1; j < Col; j++)
                            values[l, j] -= values[k, j] * f;

                        /* filling lower triangular matrix with
                        *  zeros*/
                        values[l, k] = 0;
                    }
                }
            }
        }

        public class SquareMatrix : Matrix
        {
            public SquareMatrix(int n) : base(n, n)
            {
                if (this.Row != this.Col) throw new Exception("isn't square matrix");
            }

            public SquareMatrix(double[,] ar) : base(ar)
            {
                if (this.Row != this.Col) throw new Exception("isn't square matrix");
            }


            public SquareMatrix(SquareMatrix other) : base(other)
            {
            }


            public SquareMatrix(Matrix other) : base(other)
            {
                if (other.Col != other.Row) throw new Exception("is not square");
            }

            public static SquareMatrix operator ~(SquareMatrix a) =>
                new SquareMatrix((Matrix)(~a));


            //maybe private
            protected static SquareMatrix EraseRowCol(SquareMatrix m, int r, int c)
            {
                int n = m.Col;
                double[,] ar = new double[n - 1, n - 1];
                List<double> temp = new List<double>();

                for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == r || j == c) continue;
                    else temp.Add(m.values[i, j]);
                }

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                        ar[i, j] = temp.ElementAt(j);
                    for (int k = 0; k < n - 1; k++)
                        temp.RemoveAt(0);
                }

                return new SquareMatrix(ar);
            }

            public double Det
            {
                get
                {
                    if (this.Col == 1)
                        return this.values[0, 0];
                    if (this.Col == 2)
                        return this.values[0, 0] * this.values[1, 1] - this.values[0, 1] * this.values[1, 0];

                    double res = 0;
                    int n = this.Col;
                    for (int i = 0; i < n; i++)
                    {
                        double a = this.values[i, 0];
                        int sgn = Convert.ToInt32(Math.Pow(-1, i));

                        SquareMatrix minor = EraseRowCol(this, i, 0);

                        res += sgn * a * minor.Det;
                    }

                    return res;
                }
            }
        }
    }
}