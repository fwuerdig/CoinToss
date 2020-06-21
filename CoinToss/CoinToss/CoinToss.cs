using System;

namespace CoinToss
{
    class CoinToss
    {
        public string tossACoin()
        {
            Random random = new Random();
            int toss = Math.Abs(random.Next()) % 2;
            if (toss == 0)
                return "HEADS";
            else
                return "TAILS";
        }
        static void Main(string[] args)
        {
            Console.Write("Choose how many times do you wish to flip the coin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            CoinToss coinGame = new CoinToss();
            for (int i = 0; i < n; i++)
                Console.WriteLine(coinGame.tossACoin());
        }
    }
}
