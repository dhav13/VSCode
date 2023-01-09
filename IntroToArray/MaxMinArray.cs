// Problem Description
// Write a program to print maximum and minimum elements of the input array A of size N. 
// The only line of the input would contain a single integer N that represents the length 
// of the array followed by the N elements of the input array A.
// Problem constraints

// 1 <= N <= 1000

// 1 <= A <= 1000

// Input Format
// The first line contains a single integer N representing the length of the array A followed 
// by N elements of the array A.


// Output Format
// A single line output containing two space-separated integers.
// The first integer is the maximum value of the array.
// The second integer is the minimum value of the array.

// Example Input

// Input 1:
// 5 1 2 3 4 5
// Input 2:
// 4 10 50 40 80

// Example Output
// Output 1:
// 5 1
// Output 2:
// 80 10

// Note: There is no space after the minimum value in the output format. 
//There is only a single space between the maximum and minimum value.

namespace Scaler
{
    public class MaxMinArray
    {
        public static void Main()
        {
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = 0;
            int min = int.MaxValue;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > max)
                    max = arr[j];
                else if (arr[j] < min)
                    min = arr[j];
            }
            Console.Write(max + " " + min);
        }
    }
}