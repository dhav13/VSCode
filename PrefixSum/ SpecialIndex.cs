// Problem Description
// Given an array, arr[] of size N, the task is to find the count of array indices such that removing an element 
// from these indices makes the sum of even-indexed and odd-indexed array elements equal.

// Problem Constraints
// 1 <= n <= 105
// -105 <= A[i] <= 105

// Input Format
// First argument contains an array A of integers of size N

// Output Format
// Return the count of array indices such that removing an element from these indices makes the sum of 
// even-indexed and odd-indexed array elements equal.

// Example Input
// Input 1:
// A=[2, 1, 6, 4]

// Input 2:
// A=[1, 1, 1]

// Example Output
// Output 1:
// 1

// Output 2:
// 3

// Example Explanation
// Explanation 1:

// Removing arr[1] from the array modifies arr[] to { 2, 6, 4 } such that, arr[0] + arr[2] = arr[1]. 
// Therefore, the required output is 1. 

// Explanation 2:
// Removing arr[0] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
// Removing arr[1] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
// Removing arr[2] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
// Therefore, the required output is 3.

namespace Scaler
{
    public class SpecialIndex
    {
        static void SpecialIndx(int[] arr)
        {
            int n = arr.Length;
            //Build two PreFix Sum of Even and Odd
            int[] evenSum = new int[n];
            int[] oddSum = new int[n];

            evenSum[0] = arr[0];
            oddSum[0] = 0;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum[i] = oddSum[i - 1] + arr[i];
                    evenSum[i] = evenSum[i - 1];
                }
                else
                {
                    evenSum[i] = evenSum[i - 1] + arr[i];
                    oddSum[i] = oddSum[i - 1];
                }
            }

            for (int k = 0; k < evenSum.Length; k++)
            {
                Console.Write(evenSum[k]);
            }
            Console.WriteLine();

            for (int k = 0; k < oddSum.Length; k++)
            {
                Console.Write(oddSum[k]);
            }

            int eSum = 0;
            int oSum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    eSum = oddSum[n - 1] - oddSum[i];
                    oSum = evenSum[n - 1] - evenSum[i];
                }
                else
                {
                    eSum = evenSum[i - 1] + (oddSum[n - 1] - oddSum[i]);
                    oSum = oddSum[i - 1] + (evenSum[n - 1] - evenSum[i]);
                }
                if (eSum == oSum)
                {
                    count++;
                }
            }

            Console.Write(count);

        }
        public static void Main()
        {
            int[] arr = { 1, 1, 1 };
            SpecialIndx(arr);
        }
    }
}