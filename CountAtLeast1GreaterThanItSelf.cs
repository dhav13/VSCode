namespace Scaler
{
    public static class CountAtLeast1GreaterThanItSelf
    {
        static void BrutForceWay(int[] input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }

        // static void optimizedWay(int[] input)
        // {

        // }
        public static void Main()
        {
            int[] input = { -3, 2, 5, 8, 6, 7, 8, 10, -2 };
            BrutForceWay(input);

            //optimizedWay(input);
        }
    }
}