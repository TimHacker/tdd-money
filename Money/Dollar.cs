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
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
            // TODO: write your implementation of Equals() here
            return true;
        }
    }
}