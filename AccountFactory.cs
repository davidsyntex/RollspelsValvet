using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollspelsValvet
{
    public static class AccountFactory
    {
        public enum Type
        {
            Bank,
            Debt
        }

        public static IAccount Build(Type accountType, string name)
        {
            IAccount account = null;

            switch (accountType)
            {
                case Type.Bank:
                    account = new Account(name);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(accountType), accountType, null);
            }
            return account;
        }
    }
}
