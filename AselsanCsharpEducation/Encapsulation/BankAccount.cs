using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Encapsulation
{
    public class BankAccountClient
    {
        public BankAccountClient()
        {
            var x = new BankAccount("xx");
        }
    }


    public class BankAccount(string accountNumber)
    {
        private string _accountNumber = accountNumber;
        private decimal _balance;

        public void SetBalance(decimal amount)
        {
            if (amount <= 5000 || amount >= 10000)
            {
                throw new Exception("mikatar 5000 ile 10000 arasında olmalıdır");
            }

            _balance = amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("miktar 0'dan büyük olması gerekmektedir.");
            }

            if (amount > _balance)
            {
                throw new Exception("çekilecek miktar, mevcut bakiyeden fazla olamaz");
            }


            _balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("miktar 0'dan büyük olması gerekmektedir.");
            }


            _balance += amount;
        }
    }
}