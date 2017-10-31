using System;
using System.Collections.Generic;
using System.Text;

namespace DesignQuestions
{
    class MakingChange
    {
        int[] coins;
        int depthOfRecursion;

        public MakingChange()
        {
            Coins = 0;
            coins = new int[] { 25, 10, 5, 1};
        }

        public int Coins { get => depthOfRecursion; set => depthOfRecursion = value; }

        public void change(int amount)
        {
            if (amount == 0) return;

            foreach (var coin in coins)
            {
                if (amount - coin >= 0)
                {
                    change(amount - coin);
                    break;
                }
            }

            Coins++;
        }
    }
}
