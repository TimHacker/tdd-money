using System;

namespace Money
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public Dollar Times(int multiplier)
        {
            Amount *= multiplier;

            return null;
        }
    }
}