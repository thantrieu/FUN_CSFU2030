///<resultmary>
///<author>Branium Academy</author>
///<see cref="Trang chủ" href="https://braniumacademy.net"/>
///<version>2022.04.12</version>
///</resultmary>

using System;

namespace ExercisesLesson65
{
    class Exercises2
    {
        static void Main()
        {
            // cho phép hiển thị tiếng Việt trên màn hình output
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // lưu ý màn hình console không hỗ trợ nhập liệu bằng tiếng Việt

            int choice;
            BankAccount[] accounts = new BankAccount[100];
            int size = 0;
            do
            {
                Console.WriteLine("************ CÁC CHỨC NĂNG ************");
                Console.WriteLine("* 1. Tạo mới tài khoản.               *");
                Console.WriteLine("* 2. Kiểm tra số dư của tài khoản.    *");
                Console.WriteLine("* 3. Nạp tiền vào tài khoản.          *");
                Console.WriteLine("* 4. Rút tiền khỏi tài khoản.         *");
                Console.WriteLine("* 5. Chuyển tiền sang tài khoản khác. *");
                Console.WriteLine("* 6. Hiển thị danh sách tài khoản.    *");
                Console.WriteLine("* 7. Kết thúc chương trình.           *");
                Console.WriteLine("***************************************");
                Console.WriteLine("Xin mời bạn chọn chức năng: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        var acc = BankAccountUtils.CreateAccount();
                        accounts[size++] = acc;
                        break;
                    case 2:
                        if (size > 0)
                        {
                            BankAccountUtils.CheckBalance(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 3:
                        if (size > 0)
                        {
                            BankAccountUtils.Deposit(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 4:
                        if (size > 0)
                        {
                            BankAccountUtils.Withdraw(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 5:
                        if (size > 0)
                        {
                            BankAccountUtils.BankTransfer(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 6:
                        if (size > 0)
                        {
                            BankAccountUtils.ShowAccounts(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 7:
                        Console.WriteLine("==> Chương trình kết thúc <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 7);
        }
    }

    static class BankAccountUtils
    {
        // phương thức hiển thị thông tin tài khoản rỗng danh sách
        public static void ShowAccounts(BankAccount[] accounts)
        {
            var titleAccNum = "Số TK";
            var titleOwner = "Chủ TK";
            var titleBalance = "Số Dư";
            var titleBankName = "Ngân Hàng";
            var titleExpiredDate = "Hết Hạn";
            var titlePIN = "Mã PIN";
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
        public static BankAccount FindAccountByAccNumber(BankAccount[] accounts, long accNum)
        {
            foreach (var item in accounts)
            {
                if (item != null && item.AccountNumber == accNum)
                {
                    return item;
                }
            }
            return null;
        }

        // phương thức chuyển tiền
        public static void BankTransfer(BankAccount[] accounts)
        {
            Console.WriteLine("Nhập số tài khoản nguồn: ");
            var srcAccNum = long.Parse(Console.ReadLine());
            var srcAccount = FindAccountByAccNumber(accounts, srcAccNum);
            Console.WriteLine("Nhập số tài khoản đích: ");
            var destAccNum = long.Parse(Console.ReadLine());
            var destAccount = FindAccountByAccNumber(accounts, destAccNum);
            if (srcAccount == null)
            {
                Console.WriteLine("==> Tài khoản nguồn không tồn tại. <==");
                return;
            }
            if (destAccount == null)
            {
                Console.WriteLine("==> Tài khoản đích không tồn tại. <==");
            }
            Console.WriteLine("Nhập số tiền cần chuyển: ");
            var amount = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mã PIN tài khoản nguồn: ");
            var pin = int.Parse(Console.ReadLine());
            if (srcAccount.PIN == pin)
            {
                var result = srcAccount.Transfer(destAccount, amount);
                if (result > 0)
                {
                    Console.WriteLine("==> Chuyển tiền thành công! <==");
                }
                else
                {
                    Console.WriteLine("==> Số tiền cần chuyển không hợp lệ. <==");
                }
            }
            else
            {
                Console.WriteLine("==> Ma PIN không dung <==");
            }
        }

        // phương thức rút tiền từ tài khoản
        public static void Withdraw(BankAccount[] accounts)
        {
            Console.WriteLine("Nhập số tài khoản: ");
            var accNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tiền cần rút: ");
            var amount = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mã PIN: ");
            var pin = int.Parse(Console.ReadLine());
            for (int i = 0; i < accounts.Length; i++)
            {
                var item = accounts[i];
                if (item != null && item.AccountNumber == accNum &&
                    pin == item.PIN)
                {
                    var result = item.Withdraw(amount);
                    if (result > 0)
                    {
                        Console.WriteLine("==> Rút tiền thành công! <==");
                        item.CheckBalance();
                    }
                    else
                    {
                        Console.WriteLine("==> Số tiền cần rút không hợp lệ. <==");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("==> Tài khoản không tồn tại hoặc mã PIN không đúng. <==");
                }
            }
        }

        // phương thức nạp tiền vào tài khoản
        public static void Deposit(BankAccount[] accounts)
        {
            Console.WriteLine("Nhập số tài khoản: ");
            var accNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tiền cần nạp: ");
            var amount = long.Parse(Console.ReadLine());
            bool isSuccess = false;
            for (int i = 0; i < accounts.Length; i++)
            {
                var item = accounts[i];
                if (item != null && item.AccountNumber == accNum)
                {
                    isSuccess = true;
                    item.Deposit(amount);
                    Console.WriteLine("==> Nạp tiền thành công! <==");
                    break;
                }
            }
            if (!isSuccess)
            {
                Console.WriteLine("==> Tài khoản cần nạp tiền không tồn tại. <==");
            }
        }

        // phương thức kiểm tra số dư
        public static void CheckBalance(BankAccount[] accounts)
        {
            Console.WriteLine("Số tài khoản cần kiểm tra: ");
            var accNum = long.Parse(Console.ReadLine());
            bool isAccountExisted = false;
            foreach (var item in accounts)
            {
                if (item != null)
                {
                    if (item.AccountNumber == accNum)
                    {
                        item.CheckBalance();
                        isAccountExisted = true;
                        break;
                    }
                }
            }
            if (!isAccountExisted)
            {
                Console.WriteLine("==> Số tài khoản trên không tồn tại. <==");
            }
        }

        // phương thức nhập thông tin tài khoản
        public static BankAccount CreateAccount()
        {
            Console.WriteLine("Tên tài khoản: ");
            var owner = Console.ReadLine().ToUpper();
            Console.WriteLine("Số dư: ");
            var balance = long.Parse(Console.ReadLine());
            Console.WriteLine("Ngân hàng phát hành: ");
            var bank = Console.ReadLine();
            Console.WriteLine("Ngày hết hạn: ");
            var expiredDate = Console.ReadLine();
            Console.WriteLine("Mã PIN(6 số):");
            var pin = int.Parse(Console.ReadLine());
            return new BankAccount(0, owner, balance, bank, expiredDate, pin);
        }
    }
}
