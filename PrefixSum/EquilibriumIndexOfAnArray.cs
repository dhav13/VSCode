// You are given an array A of integers of size N.
// Your task is to find the equilibrium index of the given array
// The equilibrium index of an array is an index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes.

// NOTE:
// Array indexing starts from 0.
// If there is no equilibrium index then return -1.
// If there are more than one equilibrium indexes then return the minimum index.

// Problem Constraints
// 1 <= N <= 105
// -105 <= A[i] <= 105

// Input Format
// First arugment is an array A .

// Output Format
// Return the equilibrium index of the given array. If no such index is found then return -1.

// Example Input

// Input 1:
// A=[-7, 1, 5, 2, -4, 3, 0]

// Input 2:
// A=[1,2,3]

// Example Output
// Output 1:
// 3

// Output 2:
// -1

// Example Explanation

// Explanation 1:
// 3 is an equilibrium index, because: 
// A[0] + A[1] + A[2] = A[4] + A[5] + A[6]

// Explanation 2:
// There is no such index.

namespace Scaler
{
    public class EquilibriumIndex : Base
    {

        static void EquilibriumIndx_ArraySum(int[] A)
        {
            int sum = 0, leftSum = 0, ind = -1;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            for (int j = 0; j < A.Length; j++)
            {
                sum -= A[j];
                if (leftSum == sum)
                {
                    ind = j;
                    break;
                }
                leftSum += A[j];
            }
            Console.WriteLine(ind);

        }
        static void EquilibriumIndx_PreFix(int[] A)
        {
            //Build PS
            int[] ps = new int[A.Length];
            ps[0] = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                ps[i] = ps[i - 1] + A[i];
            }

            int sumL = 0, sumR = 0, ind = -1;
            for (int i = 1; i < ps.Length; i++)
            {
                // if (i == 0)
                // {
                //     sumL = 0;
                // }
                // if (i == ps.Length - 1)
                // {
                //     sumR = 0;
                // }
                // else
                // {
                sumL = ps[i - 1];
                sumR = ps[ps.Length - 1] - ps[i];
                if (sumL == sumR)
                {
                    ind = i;
                    break;
                }
                //}
            }
            Console.WriteLine(ind);
        }

        public static void Main()
        {
            int[] A = { -7, 1, 5, 2, -4, 3, 0 };

            watch.Start();
            //Using PreFix-Sum
            EquilibriumIndx_PreFix(A);
            watch.Stop();
            Console.WriteLine("TimeTaken PreFix " + watch.ElapsedMilliseconds);


            watch.Start();
            //Using Array-Sum
            EquilibriumIndx_ArraySum(A);
            watch.Stop();
            Console.WriteLine("TimeTaken ArraySum " + watch.ElapsedMilliseconds);
        }
    }
}