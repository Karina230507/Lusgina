using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6
{
    public class BankAccount
    {
        // Поля
        public string accountNumber;
        public double balance = 0;  // начальный баланс 0

        // Метод для внесения денег
        public void Deposit(double amount)
        {
            balance = balance + amount;  // или balance += amount
            Console.WriteLine($"Внесено {amount}. Текущий баланс: {balance}");
        }

        // Метод для снятия денег
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else
            {
                balance = balance - amount;  // или balance -= amount
                Console.WriteLine($"Снято {amount}. Текущий баланс: {balance}");
            }
        }
    }
}
