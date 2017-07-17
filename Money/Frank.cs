using System;

namespace Money
{
    public class Frank
    {
        public Frank(int amount)
        {
            _amount = amount;
        }

        private int _amount;

        public Frank Times(int multiplier)
        {
            return new Frank(_amount * multiplier);
        }

        // override object.Equals
        public override bool Equals (object obj)
        {
            Frank frank = (Frank)obj;

            return _amount == frank._amount;
        }
    }
}