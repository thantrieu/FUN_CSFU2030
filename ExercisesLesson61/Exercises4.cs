///<resultmary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.06</version>
///</resultmary>

using System;

namespace ExercisesLesson61
{
    class BankAccount
    {
        public string AccountNumber { get; set; } // số tài khoản
        public string Owner { get; set; } // chủ tài khoản
        public long Balance { get; set; } // số dư
        public string Bank { get; set; } // ngân hàng phát hành
        public string ExpiredDate { get; set; } // ngày hết hạn
        public int PIN { get; set; } // mã pin

        public BankAccount()
        {

        }

        public BankAccount(string accNum, string owner, 
            long balance, string bank, string exp, int pin)
        {
            AccountNumber = accNum;
            Owner = owner;
            Balance = balance;
            Bank = bank;
            ExpiredDate = exp;
            PIN = pin;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"==> Thong tin so du tai khoan {AccountNumber}: ");
            Console.WriteLine("So tien hien co trong tai khoan la: " + Balance + "d");
        }
        // rút tiền 
        public long Withdraw(long amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                return amount;
            }
            else
            {
                return 0;
            }
        }
        // nạp tiền vào tài khoản
        public long Deposit(long amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return amount;
            }
            return 0;
        }
        // chuyển tiền đến ngân hàng khác
        public long Transfer(BankAccount other, long amount)
        {
            if (other != null && amount < Balance)
            {
                other.Balance += amount;
                Balance -= amount;
                return amount;
            }
            return 0;
        }
    }
    class Exercises4
    {

    }
}
