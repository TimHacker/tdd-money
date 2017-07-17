using System;

namespace Money
{
    public class Frank : Money
    {
        public Frank(int amount)
        {
            _amount = amount;
        }

        public Frank Times(int multiplier)
        {
            return new Frank(_amount * multiplier);
        }
    }
}