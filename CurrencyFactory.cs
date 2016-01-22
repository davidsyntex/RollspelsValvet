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

        public static ICurrency BuildCurrency(Type currencyType)
        {
            ICurrency currency = null;

            switch (currencyType)
            {
                case Type.FourteenthAge:
                    currency = new CurrencyFourteenthAge("14th Age");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(currencyType), currencyType, null);
            }
            return currency;
        }
    }
}