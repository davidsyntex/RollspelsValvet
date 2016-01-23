using System;

namespace RollspelsValvet
{
    public static class CurrencyFactory
    {
        public enum Type
        {
            FourteenthAge,
            ShadowChronicle
        }

        public static ICurrency Build(Type currencyType)
        {
            ICurrency currency = null;

            switch (currencyType)
            {
                case Type.FourteenthAge:
                    currency = new CurrencyFourteenthAge();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(currencyType), currencyType, null);
            }
            return currency;
        }
    }
}