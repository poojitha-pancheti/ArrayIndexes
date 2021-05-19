using System;
using System.Collections.Generic;
using System.Text;

namespace IndexesArraysSum.Arrays
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 7, 9, 7, 13 };
            int[] arr2 = new int[] { 5, -7, 10, 7, 34, -5 };

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    int sum = 0;
                    sum = arr1[i] + arr2[j];
                    if (sum == 0)
                    {
                        Console.WriteLine(i + "," + j);
                    }
                }
            }

        }
    }
}
