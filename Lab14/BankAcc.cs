using System;
using System.Diagnostics;

namespace Lab14
{
    enum Type
    {
        Сберегательный,
        Текущий
    }
    internal class BankAcc 
    {
        private string userName;
        private uint acc_num;
        private long balance;
        private Type type;
        public string UserName { get { return userName; } set { userName = value; } }
        public Type Type { get { return type; } }
        public uint AccountNumber { get { return acc_num; } }
        public long Balans { get { return balance; } set { balance = value; } }

        public BankAcc(string userName, uint acc_num, long balance, Type type)
        {
            this.userName = userName;
            this.acc_num = acc_num;
            this.balance = balance;
            this.type = type;
        }

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

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen() //(14.1)
        {
            Console.WriteLine($"Имя владельца аккаунта: {userName}\nНомер счёта {acc_num}\nТип счёта: {type}\nБаланс: {balance}");
        }
    }
}
