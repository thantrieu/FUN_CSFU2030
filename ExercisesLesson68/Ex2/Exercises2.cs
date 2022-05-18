/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.17</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary>


using System;
using System.Text;

namespace ExercisesLesson68
{
    class Exercises2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Account[] accounts = new Account[100];
            int numOfAccount = 0; // số lượng tài khoản
            int choice;
            do
            {
                Console.WriteLine("================== CÁC CHỨC NĂNG ==================");
                Console.WriteLine("1. Thêm mới tài khoản vào danh sách.");
                Console.WriteLine("2. Kiểm tra số dư trong tài khoản.");
                Console.WriteLine("3. Nạp tiền vào tài khoản.");
                Console.WriteLine("4. Rút tiền khỏi tài khoản.");
                Console.WriteLine("5. Chuyển tiền sang tài khoản khác.");
                Console.WriteLine("6. Hiển thị danh sách tài khoản ra màn hình.");
                Console.WriteLine("7. Sắp xếp danh sách tài khoản theo số dư giảm dần.");
                Console.WriteLine("8. Tìm tài khoản theo 4 số cuối của số tài khoản.");
                Console.WriteLine("9. Thoát chương trình.");
                Console.WriteLine("==> Xin mời bạn chọn chức năng: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("==> Xin mời chọn: ");
                        Console.WriteLine("1. Tạo tài khoản thanh toán.");
                        Console.WriteLine("2. Tạo tài khoản tiết kiệm.");
                        var option = int.Parse(Console.ReadLine());
                        var newAcc = CreateAccount(option);
                        if(newAcc != null)
                        {
                            accounts[numOfAccount++] = newAcc;
                        }
                        break;
                    case 2:
                        if (numOfAccount > 0)
                        {
                            Console.WriteLine("Nhập vào số tài khoản: ");
                            var accNumber = long.Parse(Console.ReadLine());
                            CheckAccBalance(accounts, accNumber);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 3:
                        if (numOfAccount > 0)
                        {
                            Console.WriteLine("Nhập vào số tài khoản: ");
                            var accNumber = long.Parse(Console.ReadLine());
                            Deposit(accounts, accNumber);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 4:
                        if (numOfAccount > 0)
                        {
                            Console.WriteLine("Nhập vào số tài khoản: ");
                            var accNumber = long.Parse(Console.ReadLine());
                            Console.WriteLine("Mã PIN: ");
                            var pin = int.Parse(Console.ReadLine());
                            Console.WriteLine("Số tiền cần rút(đơn vị 1kđ = 1000đ): ");
                            var amount = long.Parse(Console.ReadLine()) * 1000;
                            Withdraw(accounts, accNumber, pin, amount);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 5:
                        if (numOfAccount > 0)
                        {
                            Console.WriteLine("Số tài khoản nguồn: ");
                            var accNumber = long.Parse(Console.ReadLine());
                            Console.WriteLine("Số tài khoản đích: ");
                            var destAccNumber = long.Parse(Console.ReadLine());
                            Console.WriteLine("Mã PIN: ");
                            var pin = int.Parse(Console.ReadLine());
                            Console.WriteLine("Số tiền cần chuyển(đơn vị 1kđ = 1000đ): ");
                            var amount = long.Parse(Console.ReadLine()) * 1000;
                            BankTransfer(accounts, accNumber, destAccNumber, pin, amount);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 6:
                        if (numOfAccount > 0)
                        {
                            ShowAccountList(accounts);
                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 7:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 8:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 9:
                        Console.WriteLine("==> Cảm ơn quý khách đã sử dụng dịch vụ! <==");
                        break;
                    default:
                        Console.WriteLine("==> Sai chức năng. Vui lòng chọn lại! <==");
                        break;
                }
            } while (choice != 9);
        }

        private static void BankTransfer(Account[] accounts, long accNumber, 
            long destAccNumber, int pin, long amount)
        {
            
        }

        // phương thức rút tiền khỏi tài khoản
        private static void Withdraw(Account[] accounts, long accNumber, int pin, long amount)
        {
            Console.WriteLine("Rút tiền tại ngân hàng: ");
            var bank = Console.ReadLine();
            bool isFound = false;
            for (int i = 0; i < accounts.Length; i++)
            {
                if(accounts[i] == null)
                {
                    break;
                }
                if(accounts[i].AccNumber == accNumber)
                {
                    isFound = true;
                    if(pin == accounts[i].Pin)
                    {
                        var withdrawResult = accounts[i].Withdraw(bank, amount);
                        if(withdrawResult > 0)
                        {
                            Console.WriteLine("==> Rút tiền thành công. <==");
                        } else
                        {
                            Console.WriteLine("==> Rút tiền thất bại. <==");
                        }
                    } else
                    {
                        Console.WriteLine("==> Mã PIN không đúng. <==");
                    }
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("==> Không tìm thấy tài khoản cần rút tiền. <==");
            }
        }

        // phương thức nạp tiền vào tài khoản
        private static void Deposit(Account[] accounts, long accNumber)
        {
            Console.WriteLine("Nhập số tiền cần nạp(đơn vị kđ): ");
            var amount = long.Parse(Console.ReadLine()) * 1000;
            var isFound = false;
            for (int i = 0; i < accounts.Length; i++)
            {
                if(accounts[i] == null)
                {
                    break;
                }
                if(accounts[i].AccNumber == accNumber)
                {
                    var result = accounts[i].Deposit(amount);
                    isFound = true;
                    if(result > 0)
                    {
                        Console.WriteLine("==> Nạp tiền thành công. <==");
                    } else
                    {
                        Console.WriteLine("==> Nạp tiền thất bại. <==");
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("==> Không tìm thấy tài khoản cần nạp tiền. <==");
            }
        }

        // phương thức kiểm tra số dư trong tài khoản
        private static void CheckAccBalance(Account[] accounts, long accNumber)
        {
            var isFound = false;
            foreach (var item in accounts)
            {
                if(item == null)
                {
                    break;
                }
                if(item.AccNumber == accNumber)
                {
                    item.CheckBallance();
                    isFound = true;
                    break;
                }
            }
            if(!isFound)
            {
                Console.WriteLine("==> Không tìm thấy tài khoản cần kiểm tra. <==");
            }
        }

        // tạo tài khoản từ lựa chọn đưa ra
        private static Account CreateAccount(int choice)
        {
            Console.WriteLine("Chủ tài khoản: ");
            var owner = Console.ReadLine().ToUpper();
            Console.WriteLine("Số dư theo đơn vị kđ(1 kđ = 1000đ): ");
            var balance = long.Parse(Console.ReadLine()) * 1000;
            Console.WriteLine("Ngân hàng: ");
            var bank = Console.ReadLine();
            Console.WriteLine("Ngày hết hạn(vd: 01/01/2030): ");
            var expiredDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("Mã PIN: ");
            var pin = int.Parse(Console.ReadLine());
            Account account = new Account(0, owner, balance, bank, expiredDate, pin, 0, 0);
            if(choice == 1)
            {
                return CreateCheckingAccount(account);
            } else if(choice == 2)
            {
                return CreateSavingAccount(account);
            }
            return null; // các trường hợp còn lại
        }

        // tạo tài khoản tiết kiệm
        private static SavingAccount CreateSavingAccount(Account account)
        {
            Console.WriteLine("Kì hạn: ");
            var term = int.Parse(Console.ReadLine());
            Console.WriteLine("Lãi suất: ");
            var interestRate = double.Parse(Console.ReadLine());
            return new SavingAccount(account.AccNumber, account.Owner, account.Balance, 
                account.BankName, account.ExpiredDate, account.Pin, 
                account.TotalDailyTransaction, account.TotalDailyTransfer, term, interestRate, 0);
        }

        // tạo tài khoản thanh toán
        private static CheckingAccount CreateCheckingAccount(Account account)
        {
            Console.WriteLine("Hạn mức kđ: ");
            var limit = long.Parse(Console.ReadLine()) * 1000;
            Console.WriteLine("Phí thanh toán nội ngân hàng kđ: ");
            var intraFee = long.Parse(Console.ReadLine()) * 1000;
            Console.WriteLine("Phí thanh toán liên ngân hàng kđ: ");
            var interFee = long.Parse(Console.ReadLine()) * 1000;
            var checkAcc = new CheckingAccount(account.AccNumber, account.Owner, account.Balance,
                account.BankName, account.ExpiredDate, account.Pin,
                account.TotalDailyTransaction, account.TotalDailyTransfer, limit, interFee, intraFee);
            return checkAcc;
        }

        // phương thức hiển thị thông tin tài khoản
        private static void ShowAccountList(Account[] accounts)
        {
            var accNumber = "Số tài khoản";
            var owner = "Chủ tài khoản";
            var balance = "Số dư";
            var bankName = "Ngân hàng";
            var expiredDate = "Ngày hết hạn";
            var pinNumber = "Mã PIN";
            var dailyTransaction = "Tổng tiền GD";
            var dailyTransfer = "Tổng chuyển";
            Console.WriteLine($"{accNumber,-20:d}{owner,-25:d}" +
                $"{balance,-15:d}{bankName,-15:d}{expiredDate,-20:d}" +
                $"{pinNumber,-10:d}{dailyTransaction,15:d}{dailyTransfer,15:d}");
            foreach (var item in accounts)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.AccNumber,-20:d}{item.Owner,-25:d}" +
                        $"{item.Balance,-15:d}{item.BankName,-15:d}{item.ExpiredDate,-20:d}" +
                        $"{item.Pin,-10:d}{item.TotalDailyTransaction,15:d}{item.TotalDailyTransfer,15:d}");
                }
            }
        }
    }

    // lớp mô tả thông tin tài khoản
    class Account
    {
        private static long autoId = (long)1e13;

        public long AccNumber { get; set; }          // số tài khoản
        public string Owner { get; set; }           // chủ tài khoản
        public long Balance { get; set; }           // số dư
        public string BankName { get; set; }        // tên ngân hàng phát hành
        public DateTime ExpiredDate { get; set; }   // ngày hết hiệu lực
        public int Pin { get; set; }                // mã PIN
        public long TotalDailyTransfer { get; set; }     // số tiền đã chuyển trong 1 ngày
        public long TotalDailyTransaction { get; set; } // tổng tiền đã giao dịch trong ngày

        // các constructor
        public Account() { }

        public Account(long id)
        {
            AccNumber = id > 0 ? id : autoId++;
        }

        public Account(long accNumber, string owner, long ballance,
            string bank, DateTime expired, int pin, long dailyTransaction,
            long totalDailyTransfer) : this(accNumber)
        {
            Owner = owner;
            Balance = ballance;
            BankName = bank;
            ExpiredDate = expired;
            Pin = pin;
            TotalDailyTransaction = dailyTransaction;
            TotalDailyTransfer = totalDailyTransfer;
        }

        public void CheckBallance()
        {
            Console.WriteLine("============ THÔNG TIN TÀI KHOẢN ============");
            Console.WriteLine($"Số tài khoản: {AccNumber}");
            Console.WriteLine($"Chủ tài khoản: {Owner}");
            Console.WriteLine($"Số dư: {Balance}đ");
            var formatter = "HH:mm:ss dd/MM/yyyy";
            Console.WriteLine($"Thời gian: {DateTime.Now.ToString(formatter)}");
            Console.WriteLine("=============================================");
        }
        // gửi tiền vào tài khoản
        public virtual long Deposit(long amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return amount;
            }
            else
            {
                Console.WriteLine("==> Số tiền cần nạp không hợp lệ. <==");
                return -1;
            }
        }
        // rút tiền khỏi tài khoản
        public virtual long Withdraw(string bank, long amount)
        {
            if (amount > 0 && !string.IsNullOrEmpty(bank))
            {
                Balance -= amount;
                TotalDailyTransaction += amount;
                return amount;
            }
            else
            {
                Console.WriteLine("==> Số tiền cần rút không hợp lệ. <==");
                return -1;
            }
        }
        // chuyển tiền từ tài khoản này sang tài khoản kia
        public virtual long Transfer(Account other, long amount)
        {
            if (amount > 0 && amount < Balance - 70000)
            {
                Balance -= amount;
                other.Balance += amount;
                TotalDailyTransaction += amount;
                return amount;
            }
            else
            {
                Console.WriteLine("==> Số tiền cần rút không hợp lệ hoặc số dư không đủ. <==");
                return -1;
            }
        }

        public override string ToString()
        {
            var formatter = "HH:mm:ss dd/MM/yyyy";
            return $"[{AccNumber}, {Owner}, {Balance}, {BankName}, " +
                $"{ExpiredDate.ToString(formatter)}, {TotalDailyTransaction}]";
        }
    }

    class SavingAccount : Account
    {
        const long MAX_LIMIT = 500000000; // hạn mức chuyển tiền
        public int Term { get; set; } // kì hạn
        public double InterestRate { get; set; } // lãi suất
        public long Interest { get; set; } // tiền lãi       

        public SavingAccount() { }

        public SavingAccount(long accNumber, string owner, long ballance,
            string bank, DateTime expired, int pin, long dailyTransaction,
            long dailyTransfer, int term, double interestRate, long interest) :
            base(accNumber, owner, ballance, bank, expired, pin, dailyTransaction, dailyTransfer)
        {
            Term = term;
            InterestRate = interestRate;
            Interest = interest;
        }

        public override long Withdraw(string bank, long amount)
        {
            if (amount > 5000000)
            {
                Console.WriteLine("==> Số tiền cần rút vượt quá ngưỡng cho phép. <==");
                return -1;
            }
            else if (amount > Balance + 51100)
            {
                Console.WriteLine("==> Số tiền cần rút vượt quá số dư khả dụng. <==");
                return -1;
            }
            else
            {
                base.Withdraw(bank, amount);
                Balance -= 1100; // trừ phí rút tiền
                return amount + 1100;
            }
        }

        public override long Transfer(Account other, long amount)
        {
            if (TotalDailyTransfer + amount > MAX_LIMIT)
            {
                Console.WriteLine("==> Bạn đã vượt hạn mức chuyển tiền trong ngày. <==");
                Console.WriteLine("==> Số tiền tối đa có thể chuyển đi: " + (MAX_LIMIT - TotalDailyTransfer));
                return -1;
            }
            else
            {
                TotalDailyTransfer += amount;
                base.Transfer(other, amount);
                return amount;
            }
        }

        public long CalculateInterest()
        {
            return (long)(Balance * InterestRate / 100);
        }
    }

    class CheckingAccount : Account
    {
        public long PaymentLimit { get; set; } // hạn mức thanh toán chuyển tiền
        public long InterbankWithdrawFee { get; set; } // phí rút tiền liên ngân hàng
        public long IntrabankWithdrawFee { get; set; } // phí rút tiền nội ngân hàng

        public CheckingAccount() { }

        public CheckingAccount(long accNumber, string owner, long ballance,
            string bank, DateTime expired, int pin, long dailyTransaction,
            long dailyTransfer, long limit, long interbank, long intrabank) :
            base(accNumber, owner, ballance, bank, expired, pin, dailyTransaction, dailyTransfer)
        {
            PaymentLimit = limit;
            InterbankWithdrawFee = interbank;
            IntrabankWithdrawFee = intrabank;
        }

        public override long Withdraw(string bank, long amount)
        {
            if (amount > 5000000)
            {
                Console.WriteLine("==> Số tiền cần rút vượt quá ngưỡng cho phép. <==");
                return -1;
            }
            else if (amount > Balance + 51100)
            {
                Console.WriteLine("==> Số tiền cần rút vượt quá số dư khả dụng. <==");
                return -1;
            }
            else
            {
                base.Withdraw(bank, amount);
                // phí rút tiền
                long widthdrawFee = InterbankWithdrawFee;
                if(bank.CompareTo(BankName) == 0)
                {
                    widthdrawFee = IntrabankWithdrawFee;
                }
                Balance -= widthdrawFee; // trừ phí rút tiền
                var fee = (long)(1.0 / 100 * amount); // phí 1%
                Balance -= fee;
                return amount + widthdrawFee + fee;
            }
        }

        public override long Transfer(Account other, long amount)
        {
            if (TotalDailyTransfer + amount > PaymentLimit)
            {
                Console.WriteLine("==> Số tiền cần chuyển vượt quá hạn mức trong ngày. <==");
                Console.WriteLine("==> Bạn chỉ có thể chuyển tối đa " + (PaymentLimit - TotalDailyTransfer));
                return -1;
            }
            else
            {
                base.Transfer(other, amount);
                TotalDailyTransfer += amount;
                return amount;
            }
        }
    }
}
