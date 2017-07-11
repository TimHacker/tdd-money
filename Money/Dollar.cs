using System;

namespace Money
{
    public class Dollar
    {
        public Dollar(int amount)
        {

        }

        public int Amount { get; set; }

        public void Times(int multiplier)
        {
            Amount = 5 * 2;
        }
    }
}