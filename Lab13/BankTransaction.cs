using System;

namespace Lab13
{
    internal class BankTransaction //(13.1)
    {
        private DateTime transactionDate;
        private decimal amount;

        public DateTime TransactionDate { get { return transactionDate; } }
        public decimal Amount { get { return amount; } }

        public BankTransaction(decimal amount)
        {
            this.amount = amount;
            transactionDate = DateTime.Now;
        }
    }
}
