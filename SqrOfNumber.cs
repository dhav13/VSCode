// Given a perfect square find the square root of given no
namespace Scaler
{
public static class SqrOfNumber
{
    static long Sqr()
    {
        long input = Convert.ToInt32(Console.ReadLine());

        long start = 1;
        long end = input/2;
        long result = 0;
        while(start<=end)
        {
            long mid = (start+end)/2;
            long sqr = mid*mid;
            if(sqr == input)
            {
                return mid;
            }
            else if(sqr<input)
            {
                start = mid + 1;
                result = -1;
            }
            else
            {
                end = mid-1;
            }
        }
        return result;
    }
    public static void Main()
    {
        long value = Sqr();
        Console.WriteLine(value);
    }
}
}