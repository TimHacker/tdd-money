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
            return new Dollar(Amount * multiplier);
        }

        // override object.Equals
        public override bool Equals (object obj)
        {
            Dollar dollar = (Dollar)obj;

            return Amount == dollar.Amount;
        }
    }
}