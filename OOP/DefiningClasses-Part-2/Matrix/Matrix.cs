using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T>
           where T : struct, 
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
        // all those intefaces make sure
        // that the class is a real number
    {
        private dynamic numMatrix;
        private int rowLength;
        private int colLength;

        public Matrix(int row, int col)
        {
            this.numMatrix = new T[row, col];
            rowLength = row;
            colLength = col;
            // a constructor which row and col are the sizes of the matrix
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.rowLength != secondMatrix.rowLength || firstMatrix.colLength != secondMatrix.colLength)
            {
                throw new ArgumentException("The size of the two matrixes is different");
                // I use this to check if the size of the two matrixes is correct
                // if it is not correct I throw an exeption because the program
                // cant continue and the user has enetered an invalid input
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.rowLength, firstMatrix.colLength);
            // making a new matrix with the same length as the first one
            // (it doesnt matter if i make it like the first or
            // the second one because in any case
            // the size would be the same because i check it and throw 
            // an exeption if its not the same so the program cant continue)

            for (int row = 0; row < firstMatrix.rowLength; row++)
            {
                for (int col = 0; col < firstMatrix.colLength; col++)
                {
                    newMatrix[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
                    // making every element in the matrix equal to the the same element in
                    // the first matrix - the same element in the second matrix
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator * (Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.colLength != secondMatrix.rowLength)
            {
                // when you multiply 2 matrixes the number of cols in the first one has to be
                // equal to the number of rows on the second one
                throw new ArgumentException("The size of the two matrixes is different");
                // I use this to check if the size of the two matrixes is correct
                // if it is not correct I throw an exeption because the program
                // cant continue and the user has enetered an invalid input
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.rowLength,secondMatrix.colLength );
            // the matrix new matrix will have the same row lenght as the first matrix
            // and the same col length as the second matrix

            for (int row = 0; row < firstMatrix.rowLength; row++)
            {
                for (int col = 0; col < secondMatrix.colLength; col++)
                {
                    dynamic sum = 0;
                    for (int i = 0; i < firstMatrix.colLength; i++)
                    {
                        sum += firstMatrix[row,i] * secondMatrix[i, col];
                    }
                    newMatrix[row, col] = sum;
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.rowLength != secondMatrix.rowLength || firstMatrix.colLength != secondMatrix.colLength)
            {
                throw new ArgumentException("The size of the two matrixes is different");
                // I use this to check if the size of the two matrixes is correct
                // if it is not correct I throw an exeption because the program
                // cant continue and the user has enetered an invalid input
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.rowLength, firstMatrix.colLength);
            // making a new matrix with the same length as the first one
            // (it doesnt matter if i make it like the first or
            // the second one because in any case
            // the size would be the same because i check it and throw 
            // an exeption if its not the same so the program cant continue)

            for (int row = 0; row < firstMatrix.rowLength; row++)
            {
                for (int col = 0; col < firstMatrix.colLength; col++)
                {
                    newMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
                    // making every element in the matrix equal to the the same element in
                    // the first matrix + the same element in the second matrix
                }
            }
            return newMatrix;
        }

        public dynamic NumMatrix
        {
            get { return this.numMatrix; }
            set { this.numMatrix = value; }
            //property for NumMatrix 
            // it is dynamic because the compilator wont
            //let me use T[,] (with dynamyc it is practically the same)
        }

        private uint value;
        // Indexer declaration
        public dynamic this[int row, int col]
        {
            get
            {
                return numMatrix[row, col];
                // when you type numMatrix[row,col] it returns the given element
            }
            set
            {
                this.numMatrix[row, col] = value;
                // this makes numMatrix[row,col] equal to the given value
            }
        }
    }
}
