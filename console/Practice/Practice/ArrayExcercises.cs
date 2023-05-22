using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ArrayExcercises
    {
        public void arrayDeclaration()
        {
            // Simple arr
            int[] arr = new int[10]; 
            int[] arr2 = new int[] {1,2,3,4,5,6,7,8,9,10};
            string[] arr3 = { "a", "b", "c"};

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i; 
            }       

            printArr(arr);
            printArr(arr2);
            printArr(arr3);
        }

        public void printArr<T>(T[] arr)
        {
            foreach (T element in arr)
                Console.Write($" - {element} - ");
            Console.WriteLine("\n");
        }

        public void maxtrixDeclaration()
        {

            int[,] matrix = new int[3,3];
            int n = 1; 
            // Fill matrix
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i,j] = n;
                    n++;
                }
            }
            // Print 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {matrix[i, j]} ");
                }
                Console.WriteLine("\n");
            }
        }

        public void vectorDeclaration()
        {
            int [][] vector = new int[5][];

            // Create
            for (int i = 0; i < 5; i++)
            {
                vector[i] = new int[i + 1];   
            }

            // Print 
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector[i].Length; j++)
                {
                    Console.Write(vector[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
