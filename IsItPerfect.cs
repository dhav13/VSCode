// Problem Description
// Take T (number of test cases) as input.
// For each test case, take integer N as input, you have to tell whether it is a perfect number or not.
// A perfect number is a positive integer that is equal to the sum of its proper positive divisors (excluding the number itself). 
// A positive proper divisor divides a number without leaving any remainder.
// Problem Constraints
// 1 <= T <= 10
// 1 <= N <= 106

// Input Format
// The first line of the input contains a single integer T.
// Each of the next T lines contains a single integer N.
// Output Format
// In a separate line, print YES if a given integer is perfect, else print NO.
// Example Input
// Input 1:
//  2
//  4
//  6 
// Example Output
// Output 1:
//  NO
//  YES
//Explanation 1:
//For A = 4, the answer is "NO" as sum of its proper divisors = 1 + 2 = 3, is not equal to 4. 
//For A = 6, the answer is "YES" as sum of its proper divisors = 1 + 2 + 3 = 6, is equal to 6. 
namespace Scaler
{
    public static class IsItPerfect
    {
        static void IsItPerfectNum(int num)
        {
            int sum = 0;
            for(int i=1;i < num;i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                }
            }
            if(sum == num)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        public static void Main()
        {
            int round = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<round;i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                IsItPerfectNum(num);
            }
        }
    }
}