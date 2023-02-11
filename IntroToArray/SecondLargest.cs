// Problem Description

// You are given an integer array A. You have to find the second largest element/value in the array or report that 
// no such element exists.

// Problem Constraints
// 1 <= |A| <= 105

// 0 <= A[i] <= 109

// Input Format
// The first argument is an integer array A.

// Output Format
// Return the second largest element. If no such element exist then return -1.

// Example Input

// Input 1:
//  A = [2, 1, 2] 

// Input 2:
//  A = [2]

// Example Output

// Output 1:
//  1 

// Output 2:
//  -1 

// Example Explanation

// Explanation 1:
//  First largest element = 2
//  Second largest element = 1

// Explanation 2:
// There is no second largest element in the array.

namespace Scaler
{
    public class SecondLargest : Base
    {

        static int SecondLargestNumber(int[] arr)
        {
            int secMax = -1;
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secMax && arr[i] < max)
                {
                    secMax = arr[i];
                }
            }
            return secMax;
        }
        public static void Main()
        {
            watch.Start();
            int[] arr = { 3, -9, 1, 4, 10, 7, 34 };
            int secMax = SecondLargestNumber(arr); //in terms of number
            watch.Stop();
            Console.WriteLine("StopWatch: " + watch.ElapsedMilliseconds);

            Console.WriteLine("Ans: " + secMax);
        }
    }
}