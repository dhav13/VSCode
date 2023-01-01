// Problem Description
// Given an integer array A of size N and an integer B, you have to print the same array after rotating it B times towards the right.

// Problem Constraints
// 1 <= N <= 106
// 1 <= A[i] <=108
// 1 <= B <= 109

// Input Format
// There are 2 lines in the input

// Line 1: The first number is the size N of the array A. Then N numbers follow which indicate the elements in the array A.

// Line 2: A single integer B.

// Output Format
// Print array A after rotating it B times towards the right.

// Example Input
// Input 1 :

// 4 1 2 3 4
// 2

// Example Output
// Output 1 :
// 3 4 1 2
// Example Explanation
// Example 1 :

// N = 4, A = [1, 2, 3, 4] and B = 2.

// Rotate towards the right 2 times - [1, 2, 3, 4] => [4, 1, 2, 3] => [3, 4, 1, 2]

// Final array = [3, 4, 1, 2]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaler
{
    public class RotationGame
    {
        static void rotate(int[] arr, int b)
        {
            if (b > arr.Length)
            {
                b = b % (arr.Length);
            }

            int start = 0; int end = arr.Length - 1;
            //complete reverse the array
            arr = reverse(arr, start, end);

            //reverse the first Kth(rotateTime) elements
            arr = reverse(arr, start, b - 1);

            //reverse the remaining elements
            arr = reverse(arr, start + b, end);

            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");
            }
            Console.WriteLine();
        }
        static int[] reverse(int[] arr, int start, int end)
        {
            int temp = 0;
            for (int i = start; i <= end; i++)
            {
                temp = arr[i];
                arr[i] = arr[end];
                arr[end] = temp;
                end--;
            }
            return arr;
        }
        public static void Main(string[] args)
        {
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int rotateTime = Convert.ToInt32(Console.ReadLine());

            rotate(inputArray, rotateTime);
        }
    }
}