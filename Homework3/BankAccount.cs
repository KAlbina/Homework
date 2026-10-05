using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    internal class BankAccount
    {
        private string _owner;
        private string _accountNumber;
        private decimal _balance;
        public string Owner
        {
            get
            {
                return _owner;
            }
        }
        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            init
            {
                _accountNumber = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Баланс счета отрицательный");
                }
                _balance = value;
            }
        }
        public BankAccount(string owner, decimal balance)
        {
            _owner = owner;
            Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма пополнения должна быть больше нуля");
            }
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма снятия должна быть больше нуля");
            }
            if (amount > Balance)
            {
                throw new ArgumentException("недостаточно седств");
            }
            Balance -= amount;
        }
        public string GetInfo()
        {
            return $"Владелец: {Owner}, номер счета: {AccountNumber}, Баланс: {Balance}";
        }

    }
}
