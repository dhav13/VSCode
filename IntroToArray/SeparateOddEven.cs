// Problem Description

// You are given an integer T denoting the number of test cases. For each test case, you are given an integer array A.
// You have to print the odd and even elements of array A in 2 separate lines.

// NOTE: Array elements should have the same relative order as in A.

// Problem Constraints
// 1 <= T <= 10
// 1 <= |A| <= 105
// 1 <= A[i] <= 109

// Input Format
// First line of the input contains a single integer T.

// For each test case:
// First line consists of a single integer |A| denoting the length of array.
// Second line consists of |A| space separated integers denoting the elements of array A.

// Output Format
// For each test case:
// First line should contain an array of space separated integers containing all the odd elements of array A
// Second line should contain an array of space separated integers containing all the even elements of array A

// Example Input
// Input 1:
//  2 
//  5
//  1 2 3 4 5
//  3
//  4 3 2

// Input 2:
//  2 
//  3
//  2 2 2
//  2
//  1 1

// Example Output
// Output 1:
//  1 3 5
//  2 4
//  3
//  4 2

// Output 2:
//  2 2 2
//  1 1

// Example Explanation

// Explanation 1:
//  Test Case 1: 
//  Odd elements in the array(in the order they occur) are: 1, 3, 5.
//  Even elements in the array(in the order they occur) are: 2, 4.

//  Test Case 2 
//  Odd elements in the array(in the order they occur) are: 3.
//  Even elements in the array(in the order they occur) are: 4, 2.

// Explanation 2:
//  Test Case 1: 
//  There are no odd elements in the array.
//  Even elements in the array(in the order they occur) are: 2, 2, 2.

//  Test Case 2 
//  Odd elements in the array(in the order they occur) are: 1, 1.
//  There are no even elements in the array.

using System.Text;

namespace Scaler
{
    public class SeparateOddEven : Base
    {
        public static void Main()
        {
            watch.Start();
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                int lenArr = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[lenArr];

                string? arrElements = Console.ReadLine();
                for (int j = 0; j < lenArr; j++)
                {
                    arr[j] = Convert.ToInt32(arrElements?.Split(" ")[j]);
                }

                for (int l = 0; l < lenArr; l++)
                {
                    if (arr[l] % 2 != 0)
                    {
                        Console.Write(arr[l] + " ");
                    }
                }

                Console.WriteLine();

                for (int k = 0; k < lenArr; k++)
                {
                    if (arr[k] % 2 == 0)
                    {
                        Console.Write(arr[k] + " ");
                    }
                }
                Console.WriteLine();
                watch.Stop();
                Console.WriteLine("Execution Time : " + watch.ElapsedMilliseconds);
            }
        }
    }
}