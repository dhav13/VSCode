// From the Indian Domination - get change of input int value
namespace Scaler
{
    public class RecursiveMoneyChange
    {
        static void MakeChange(int money)
        {
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 };
            if (money == 0)
                return;

            int i = 0;
            for (i = coins.Length - 1; i >= 0; i--)
            {
                if (coins[i] <= money)
                {
                    break;
                }
            }
            Console.WriteLine("Pick change " + coins[i]);
            int remainMoney = money - coins[i];
            MakeChange(remainMoney);
        }

        public static void Main()
        {
            int money = 247;
            MakeChange(money);
        }
    }
}