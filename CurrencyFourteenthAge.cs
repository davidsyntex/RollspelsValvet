using System.Text;

namespace RollspelsValvet
{
    public class CurrencyFourteenthAge : ICurrency
    {
        public CurrencyFourteenthAge()
        {
            Name = "14th Age";
        }

        public string Name { get; }

        public static string Format(int amount)
        {
            var tempAmount = amount;

            var guldmynt = ConvertToGoldRoundedDown(tempAmount);
            tempAmount = tempAmount % 100;
            var silvermynt = ConvertToSilverRoundedDown(tempAmount);
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

        public static double ConvertToSilver(int copperCoin)
        {
            return copperCoin / 10.0;
        }

        public static double ConvertToGold(int copperCoin)
        {
            return copperCoin / 100.0;
        }
        public static int ConvertToSilverRoundedDown(int copperCoin)
        {
            return copperCoin / 10;
        }

        public static int ConvertToGoldRoundedDown(int copperCoin)
        {
            return copperCoin / 100;
        }
    }
}