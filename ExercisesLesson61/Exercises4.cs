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
            Console.WriteLine($"So tien hien co trong tai khoan la: {Balance:n}d");
        }
        // rút tiền 
        public long Withdraw(long amount)
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
            if (other != null && amount < Balance - 50000)
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
        static void Main()
        {
            int choice;
            BankAccount[] accounts = new BankAccount[100];
            int size = 0;
            do
            {
                Console.WriteLine("================== CAC CHUC NANG ==================");
                Console.WriteLine("1. Tao moi tai khoan.");
                Console.WriteLine("2. Kiem tra so du cua tai khoan.");
                Console.WriteLine("3. Nap tien vao tai khoan.");
                Console.WriteLine("4. Rut tien khoi tai khoan.");
                Console.WriteLine("5. Chuyen tien sang tai khoan khac.");
                Console.WriteLine("6. Hien thi danh sach tai khoan ra man hinh.");
                Console.WriteLine("7. Ket thuc chuong trinh.");
                Console.WriteLine("Xin moi ban chon chuc nang: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var acc = CreateAccount();
                        accounts[size++] = acc;
                        break;
                    case 2:
                        if (size > 0)
                        {
                            CheckBalance(accounts, size);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach tai khoan trong <==");
                        }
                        break;
                    case 3:
                        if (size > 0)
                        {
                            Deposit(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach tai khoan trong <==");
                        }
                        break;
                    case 4:
                        if (size > 0)
                        {
                            Withdraw(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach tai khoan trong <==");
                        }
                        break;
                    case 5:
                        if (size > 0)
                        {
                            BankTransfer(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach tai khoan trong <==");
                        }
                        break;
                    case 6:
                        if (size > 0)
                        {
                            ShowAccounts(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sach tai khoan trong <==");
                        }
                        break;
                    case 7:
                        Console.WriteLine("==> Chuong trinh ket thuc <==");
                        break;
                    default:
                        break;
                }
            } while (choice != 7);
        }
        // phương thức hiển thị thông tin tài khoản trong danh sách
        static void ShowAccounts(BankAccount[] accounts)
        {
            var titleAccNum = "So TK";
            var titleOwner = "Chu TK";
            var titleBalance = "So Du";
            var titleBankName = "Ngan Hang";
            var titleExpiredDate = "Het Han";
            var titlePIN = "Ma PIN";
            Console.WriteLine($"{titleAccNum,-15:d}{titleOwner,-20:d}{titleBalance,-15:d}" +
                        $"{titleBankName,-15:d}{titleExpiredDate,-15:d}{titlePIN,-10:d}");
            foreach (var item in accounts)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.AccountNumber,-15:d}{item.Owner,-20:d}" +
                        $"{item.Balance,-15:d}{item.Bank,-15:d}{item.ExpiredDate,-15:d}" +
                        $"{item.PIN,-10:d}");
                }
                else
                {
                    break;
                }
            }
        }
        // phương thức tìm tài khoản theo số TK
        static BankAccount FindAccountByAccNumber(BankAccount[] accounts, string accNum)
        {
            foreach (var item in accounts)
            {
                if (item != null && item.AccountNumber.CompareTo(accNum) == 0)
                {
                    return item;
                }
            }
            return null;
        }
        // phương thức chuyển tiền
        static void BankTransfer(BankAccount[] accounts)
        {
            Console.WriteLine("Nhap so tai khoan nguon: ");
            var srcAccNum = Console.ReadLine();
            var srcAccount = FindAccountByAccNumber(accounts, srcAccNum);
            Console.WriteLine("Nhap so tai khoan dich: ");
            var destAccNum = Console.ReadLine();
            var destAccount = FindAccountByAccNumber(accounts, destAccNum);
            if (srcAccount == null)
            {
                Console.WriteLine("==> Tai khoan nguon khong ton tai. <==");
                return;
            }
            if (destAccount == null)
            {
                Console.WriteLine("==> Tai khoan dich khong ton tai. <==");
            }
            Console.WriteLine("Nhap so tien can chuyen: ");
            var amount = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma PIN tai khoan nguon: ");
            var pin = int.Parse(Console.ReadLine());
            if (srcAccount.PIN == pin)
            {
                var result = srcAccount.Transfer(destAccount, amount);
                if (result > 0)
                {
                    Console.WriteLine("==> Chuyen tien thanh cong! <==");
                }
                else
                {
                    Console.WriteLine("==> So tien can chuyen khong hop le. <==");
                }
            }
            else
            {
                Console.WriteLine("==> Ma PIN khong dung <==");
            }
        }
        // phương thức rút tiền từ tài khoản
        static void Withdraw(BankAccount[] accounts)
        {
            Console.WriteLine("Nhap so tai khoan: ");
            var accNum = Console.ReadLine();
            Console.WriteLine("Nhap so tien can rut: ");
            var amount = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma PIN: ");
            var pin = int.Parse(Console.ReadLine());
            bool isSuccess = false;
            for (int i = 0; i < accounts.Length; i++)
            {
                var item = accounts[i];
                if (item != null && item.AccountNumber.CompareTo(accNum) == 0 &&
                    pin == item.PIN)
                {
                    var result = item.Withdraw(amount);
                    if (result > 0)
                    {
                        isSuccess = true;
                        Console.WriteLine("==> Rut tien thanh cong! <==");
                        item.CheckBalance();
                    }
                    else
                    {
                        Console.WriteLine("==> So tien can rut khong hop le. <==");
                    }
                    break;
                }
            }
            if (!isSuccess)
            {
                Console.WriteLine("==> Tai khoan khong ton tai hoac ma PIN khong dung. <==");
            }
        }
        // phương thức nạp tiền vào tài khoản
        static void Deposit(BankAccount[] accounts)
        {
            Console.WriteLine("Nhap so tai khoan: ");
            var accNum = Console.ReadLine();
            Console.WriteLine("Nhap so tien can nap: ");
            var amount = long.Parse(Console.ReadLine());
            bool isSuccess = false;
            for (int i = 0; i < accounts.Length; i++)
            {
                var item = accounts[i];
                if (item != null && item.AccountNumber.CompareTo(accNum) == 0)
                {
                    isSuccess = true;
                    item.Deposit(amount);
                    Console.WriteLine("==> Nap tien thanh cong! <==");
                    break;
                }
            }
            if (!isSuccess)
            {
                Console.WriteLine("==> Tai khoan can nap tien khong ton tai. <==");
            }
        }
        // phương thức kiểm tra số dư
        static void CheckBalance(BankAccount[] accounts, int size)
        {
            Console.WriteLine("So tai khoan can kiem tra: ");
            var accNum = Console.ReadLine();
            bool isAccountExisted = false;
            foreach (var item in accounts)
            {
                if (item != null)
                {
                    if (item.AccountNumber.CompareTo(accNum) == 0)
                    {
                        item.CheckBalance();
                        isAccountExisted = true;
                        break;
                    }
                }
            }
            if (!isAccountExisted)
            {
                Console.WriteLine("==> So tai khoan tren khong ton tai. <==");
            }
        }
        // phương thức nhập thông tin tài khoản
        static BankAccount CreateAccount()
        {
            Console.WriteLine("So tai khoan: ");
            var accNum = Console.ReadLine();
            Console.WriteLine("Ten tai khoan: ");
            var owner = Console.ReadLine().ToUpper();
            Console.WriteLine("So du: ");
            var balance = long.Parse(Console.ReadLine());
            Console.WriteLine("Ngan hang phat hanh: ");
            var bank = Console.ReadLine();
            Console.WriteLine("Ngay het han: ");
            var expiredDate = Console.ReadLine();
            Console.WriteLine("Ma PIN(6 so):");
            var pin = int.Parse(Console.ReadLine());
            return new BankAccount(accNum, owner, balance, bank, expiredDate, pin);
        }
    }
}
