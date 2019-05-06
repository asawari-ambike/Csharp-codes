using System.Security.AccessControl;
using System.Runtime.CompilerServices;
using System;

namespace C__assignments
{
    public class ArrayDimension
    {
        int _rows, _cols;
        public int[,] CreateTwoDArray()
        {
            int col, row;
            Console.WriteLine("Enter the no. of rows:");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no. of columns:");
            col = Convert.ToInt32(Console.ReadLine());
            this._rows = row;
            this._cols = col;
            int[,] TwoDArray = new int[row,col];

            for (int i=0; i<row; i++)
            {
                for (int j=0; j<col; j++)
                {
                    TwoDArray[i,j] = i+j;
                }
            }
            return TwoDArray;
        }

        public void PrintArray(int[,] TwoDArray)
        {
            Console.WriteLine("The 2-D array is:");
            for(int i=0; i<_rows; i++)
            {
                for(int j=0; j<_cols; j++)
                {
                    Console.Write("{0}\t",TwoDArray[i,j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine("The 2-D array converted to 1-D array is:");
            int[] OneDArray = new int[_rows*_cols];
            int k=0;
            for(int i=0; i<_rows; i++)
            {
                for(int j=0; j<_cols; j++)
                {
                    OneDArray[k] = TwoDArray[i,j];
                    Console.Write("{0}\t",OneDArray[k]);
                    k++;
                }
                
            }

        }

        public void ArrayConversion()
        {
            ArrayDimension obj = new ArrayDimension();
            int[,] arr = obj.CreateTwoDArray();
            obj.PrintArray(arr);
        }
    }
}