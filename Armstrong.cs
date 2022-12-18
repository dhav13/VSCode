// Problem Description
// You are given an integer N you need to print all the Armstrong Numbers between 1 to N. (N inclusive).
// If sum of cubes of each digit of the number is equal to the number itself, then the number is called an Armstrong number.
// For example, 153 = ( 1 * 1 * 1 ) + ( 5 * 5 * 5 ) + ( 3 * 3 * 3 ).
// Note: All the test cases in this problem are limited to 3 digit numbers.
// Problem Constraints
// 1 <= N <= 500
// Input Format
// First and only line of input contains an integer N.
// Output Format
// Output all the Armstrong numbers in range [1,N] each in a new line.
// Example Input
// Input 1:
//  5
// Input 2:
//  200
// Example Output
// Output 1:
// 1
// Output 2:
// 1
// 153

namespace Scaler
{
    public static class Armstrong
    {
        static void ArmstrongNum(int num)
        {
            for(int i=1;i<=num;i++)
            {
                int extNum = i;
                int sum = 0;
                while(extNum > 0)
                {
                    int dNum = extNum % 10;
                    sum += (dNum * dNum * dNum);
                    extNum /= 10;
                }
                if(sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            ArmstrongNum(num);
        }
    }
}