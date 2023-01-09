//  Given an array A and an integer B. A pair(i, j) in the array is a good pair if i != j and 
//  (A[i] + A[j] == B). Check if any good pair exist or not.

// Problem Constraints
// 1 <= A.size() <= 104
// 1 <= A[i] <= 109
// 1 <= B <= 109

// Input Format
// First argument is an integer array A.
// Second argument is an integer B.

// Output Format
// Return 1 if good pair exist otherwise return 0.

// Example Input
// Input 1:
// A = [1,2,3,4]
// B = 7    

// Input 2:
// A = [1,2,4]
// B = 4

// Input 3:
// A = [1,2,2]
// B = 4

// Example Output
// Output 1:
// 1

// Output 2:
// 0

// Output 3:
// 1

// Example Explanation
// Explanation 1:
//  (i,j) = (3,4)
// Explanation 2:
// No pair has sum equal to 4.
// Explanation 3:
//  (i,j) = (2,3)

namespace Scaler
{
    public class GoodPair
    {
        public static void Main()
        {
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //non-countinues additon as below -- for countinues addition 2nd for loop not required just make arr[j] + arr[j+1]
            int num = Convert.ToInt32(Console.ReadLine());
            int isPresent = 0;
            for (int j = 0; j < arrLength - 1; j++)
            {
                for (int k = j + 1; k < arrLength; k++)
                {
                    if ((arr[j] + arr[k]) == num & j != k)
                    {
                        isPresent = 1;
                    }
                }
            }
            Console.WriteLine(isPresent);
        }
    }
}
