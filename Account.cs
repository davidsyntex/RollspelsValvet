using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace RollspelsValvet
{
    public class Account : IAccount
    {
        public string Name { get; set; }

        private int Balance { get; set; }

        public List<Transaction> Transactions { get; private set; }

        public Account(string name)
        {
            Name = name;
            Transactions = new List<Transaction>();
        }

        public int GetBalance()
        {
            return Transactions.Sum(transaction => transaction.Amount);
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}