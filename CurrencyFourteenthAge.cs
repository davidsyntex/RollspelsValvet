using System.Text;

namespace RollspelsValvet
{
    public class CurrencyFourteenthAge : ICurrency
    {
        public CurrencyFourteenthAge(string name)
        {
            Name = name;
            Amount = 0;
        }

        public string Name { get; }
        public int Amount { get; private set; }

        public void Add(int amount)
        {
            Amount += amount;
        }

        public void Subtract(int amount)
        {
            Amount -= amount;
        }

        public string Format()
        {
            var tempAmount = Amount;

            var guldmynt = tempAmount / 100;
            tempAmount = tempAmount % 100;
            var silvermynt = tempAmount / 10;
            tempAmount = tempAmount % 10;
            var kopparmynt = tempAmount;

            var stringBuilder = new StringBuilder();

            if (guldmynt > 0)
            {
                stringBuilder.Append($"{guldmynt} gm");
            }

            if (silvermynt > 0)
            {
                if (guldmynt > 0)
                {
                    stringBuilder.Append(" ");
                }
                stringBuilder.Append($"{silvermynt} sm");
            }

            if (kopparmynt > 0)
            {
                if (silvermynt > 0)
                {
                    stringBuilder.Append(" ");
                }
                stringBuilder.Append($"{kopparmynt} km");
            }

            return stringBuilder.ToString();
        }
    }
}