
namespace Money
{
    public class Money
    {
        protected int _amount;

        // override object.Equals
        public override bool Equals (object obj)
        {
            Money money = (Money)obj;

            return _amount == money._amount;
        }
    }
}