using System;

namespace Money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            _amount = amount;
        }

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