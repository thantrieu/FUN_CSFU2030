using System;

namespace ExercisesLesson65
{
    /// <summary>
    /// Lớp mô tả thông tin tài khoản ngân hàng.
    /// Phần 1 chứa các trường, thuộc tính và constructor cũng như
    /// khai báo nguyên mẫu của các phương thức.
    /// </summary>
    partial class BankAccount
    {
        // các trường dữ liệu để access modifier là private
        // số tài khoản 13 chữ số tự động tăng
        private static long AutoId { get; set; } = 10000000000000;
        // số tài khoản
        public long accNumber;

        // các thuộc tính public
        public long AccountNumber
        {
            get => accNumber; // trả về số tài khoản
            set // thiết lập giá trị cho số tài khoản
            {
                if (value < 10000000000000) // nếu truyền x < 10^13 vào => tự tạo số TK mới
                {
                    accNumber = AutoId++;
                }
                else // ngược lại, gán giá trị nhận được
                {
                    accNumber = value;
                }
            }
        }
        public string Owner { get; set; } // chủ tài khoản
        public long Balance { get; set; } // số dư
        public string Bank { get; set; } // ngân hàng phát hành
        public string ExpiredDate { get; set; } // ngày hết hạn
        public int PIN { get; set; } // mã pin

        // phương thức khởi tạo
        public BankAccount() { }

        public BankAccount(long accNum, string owner,
            long balance, string bank, string exp, int pin)
        {
            AccountNumber = accNum;
            Owner = owner;
            Balance = balance;
            Bank = bank;
            ExpiredDate = exp;
            PIN = pin;
        }

        // khai báo các phương thức
        public partial void CheckBalance();
        public partial long Withdraw(long amount);
        public partial long Deposit(long amount);
        public partial long Transfer(BankAccount other, long amount);
    }

    /// <summary>
    /// Lớp mô tả thông tin và hành động của tài khoản ngân hàng.
    /// Phần 2: triển khai chi tiết của các phương thức partial.
    /// </summary>
    partial class BankAccount
    {
        public partial void CheckBalance()
        {
            Console.WriteLine($"==> Thong tin so du tai khoan {AccountNumber}: ");
            Console.WriteLine($"So tien hien co trong tai khoan la: {Balance:n}d");
        }
        // rút tiền 
        public partial long Withdraw(long amount)
        {
            if (amount < Balance - 50000)
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
        public partial long Deposit(long amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return amount;
            }
            return 0;
        }
        // chuyển tiền đến ngân hàng khác
        public partial long Transfer(BankAccount other, long amount)
        {
            if (other != null && amount < Balance - 50000)
            {
                other.Balance += amount;
                Balance -= amount;
                return amount;
            }
            return 0;
        }
    }
}
