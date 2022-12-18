// Q1.Is It Prime?
// Problem Description
// Given an integer A as input, you have to tell whether it is a prime number or not.
// A prime number is a natural number greater than 1 which is divisible only by 1 and itself.
// Problem Constraints
// 1 <= A <= 10^6
// Input Format
// First and only line of the input contains a single integer A.
// Output Format
// Print YES if A is a prime, else print NO.
// Example  Input
// Input 1:
//  3
// Input 2:
//  4
// Example Output
// Output 1:
//  YES
// Output 2:
//  NO
// Example Explanation
// Explanation 1:
//  3 is a prime number as it is only divisible by 1 and 3.
// Explanation 2:
//  4 is not a prime number as it is divisible by 2.

namespace Scaler
{
     public static class IsItPrime
    {
        //Method 1
        static void IsPrime(int input)
        {
            bool result = true;
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    result = false;
                    break;
                }
            }
            if (result)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        //Method 2
        static void IsPrime2(int input)
        {
            int c=0;
            for(int i=1;i*i<input;i++)
            {
                if(input%i==0)
                {
                    if(i*i == input)
                        c++;
                    else
                        c+=2;
                }
            }
            if(c==2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        public static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            IsPrime(input);
            IsPrime2(input);
        }
    }
}