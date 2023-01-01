namespace Scaler
{
    public static class Door100Jailer
    {
        private static void BrutForce()
        {
            // 1 - Close, 0- Open
            //int[] doors = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] doors = new int[101];
            for (int i = 0; i < doors.Length; i++)
            {
                doors[i] = 1;
            }
            int count = 0;
            for (int round = 1; round < doors.Length; round++)
            {
                for (int j = round; j < doors.Length; j += round)
                {
                    doors[j] = 1 - doors[j];
                }
            }
            for (int k = 1; k < doors.Length; k++)
            {
                if (doors[k] == 0)
                    count++;
            }
            Console.WriteLine(count);
        }

        static void Optimized()
        {
            //Doors which are Perfect Sqr will be visited odd times
            int[] doors = new int[99];
            for (int i = 0; i < doors.Length; i++)
            {
                doors[i] = 1;
            }

            int count = (int)Math.Sqrt(doors.Length);

            Console.WriteLine(count);
        }

        public static void Main()
        {
            //BrutForce(); // O (N*logN)
            Optimized();
        }
    }
}