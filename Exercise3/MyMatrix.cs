using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class MyMatrix
    {
        private int[,] _values;

        public MyMatrix(int rows, int column)
        {
            _values = new int[rows, column];
        }

        public int this[int row, int column]
        {
            get
            {
                return _values[row, column];
            }
            set
            {
                _values[row, column] = value;
            }
        }
    }
}
