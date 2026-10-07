using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    internal class BankAccount
    {
       
        public string Owner { get; }
   
        public string AccountNumber { get; init; }
   
        public decimal Balance { get; private set; }
        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;

            if (balance < 0)
            {
                throw new ArgumentException("Баланс счета отрицательный");
            }

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
