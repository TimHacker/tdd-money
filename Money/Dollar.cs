using System;

namespace Money
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            _amount = amount;
        }

        private int _amount;

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        // override object.Equals
        public override bool Equals (object obj)
        {
            Dollar dollar = (Dollar)obj;

            return _amount == dollar._amount;
        }
    }
}