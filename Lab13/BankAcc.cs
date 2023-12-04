using System;
using System.Collections.Generic;

namespace Lab13
{
    enum Type
    {
        Сберегательный,
        Текущий
    }
    internal class BankAcc //(13.1)
    {
        private uint acc_num;
        private long balance;
        private Type type;
        public Type Type { get { return type; } }
        public uint AccountNumber { get { return acc_num; } }
        public long Balans { get { return balance; } set { balance = value; } }


        public void AddMoney(long money)
        {
            if (money > 0)
            {
                balance += money;
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }

        public void MinusMoney(long money)
        {
            if ((money <= balance) && (money > 0))
            {
                balance -= money;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }

        //для индексатора (13.2)
        private List<BankTransaction> transactions = new List<BankTransaction>();
        public List<BankTransaction> Transactions { get { return transactions; } }
        public BankTransaction this[int index]
        {
            get { return transactions[index]; }
        }
    }
}
