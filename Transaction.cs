using System;

namespace RollspelsValvet
{
    public class Transaction
    {
        public int Amount { get; private set; }

        public DateTime Day { get; private set; }

        public string Note { get; private set; }

        public Transaction(int amount, DateTime day)
        {
            Amount = amount;
            Day = day;
        }

        public void AddNote(string note)
        {
            Note = note;
        }
    }
}