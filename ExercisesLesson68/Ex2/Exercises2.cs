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

                        break;
                    case 2:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 3:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 4:
                        if (numOfAccount > 0)
                        {

                        }
                        else
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng <==");
                        }
                        break;
                    case 5:
                        if (numOfAccount > 0)
                        {

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

        // phương thức hiển thị thông tin tài khoản
        private static void ShowAccountList(Account[] accounts)
        {
            var accNumber = "Số TK";
            var owner = "Chủ TK";
            var balance = "Số dư";
            var bankName = "Ngân hàng";
            var expiredDate = "Ngày HH";
            var pinNumber = "Mã PIN";
            var dailyTransaction = "Tổng tiền GD";
            var dailyTransfer = "Tổng chuyển";
            Console.WriteLine($"{accNumber,-15:d}{owner,-25:d}" +
                $"{balance,-15:d}{bankName,-15:d}{expiredDate,-20:d}" +
                $"{pinNumber,-10:d}{dailyTransaction,15:d}{dailyTransfer,15:d}");
            foreach (var item in accounts)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.AccNumber,-15:d}{item.Owner,-25:d}" +
                        $"{item.Balance,-15:d}{item.BankName,-15:d}{item.ExpiredDate,-20:d}" +
                        $"{item.Pin,-10:d}{item.TotalDailyTransaction,15:d}{item.TotalDailyTransfer,15:d}");
                }
            }
        }
    }

    // lớp mô tả thông tin tài khoản
    class Account
    {
        private static long autoId = (long)10e13;

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
            string bank, DateTime expired, int pin, long dailyTransaction) : this(accNumber)
        {
            Owner = owner;
            Balance = ballance;
            BankName = bank;
            ExpiredDate = expired;
            Pin = pin;
            TotalDailyTransaction = dailyTransaction;
        }

        public void CheckBallance()
        {
            Console.WriteLine("============ THÔNG TIN TÀI KHOẢN ============");
            Console.WriteLine($"Số tài khoản: {AccNumber}");
            Console.WriteLine($"Chủ tài khoản: {Owner}");
            Console.WriteLine($"Số dư: {AccNumber}");
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
        public virtual long Widthdraw(string bank, long amount)
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
        const long MAX_LIMIT = 500000000;
        public int Term { get; set; } // kì hạn
        public double InterestRate { get; set; } // lãi suất
        public long Interest { get; set; } // tiền lãi       

        public SavingAccount(long accNumber, string owner, long ballance,
            string bank, DateTime expired, int pin, long dailyTransaction,
            int term, double interestRate, long interest) :
            base(accNumber, owner, ballance, bank, expired, pin, dailyTransaction)
        {
            Term = term;
            InterestRate = interestRate;
            Interest = interest;
        }

        public override long Widthdraw(string bank, long amount)
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
                base.Widthdraw(bank, amount);
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
            return (long)(Balance * InterestRate);
        }
    }

    class CheckingAccount : Account
    {
        public long PaymentLimit { get; set; }
        public long InterbankWithdrawFee { get; set; }
        public long IntrabankWithdrawFee { get; set; }

        public CheckingAccount(long accNumber, string owner, long ballance,
            string bank, DateTime expired, int pin, long dailyTransaction,
            long limit, long interbank, long intrabank) :
            base(accNumber, owner, ballance, bank, expired, pin, dailyTransaction)
        {
            PaymentLimit = limit;
            InterbankWithdrawFee = interbank;
            IntrabankWithdrawFee = intrabank;
        }

        public override long Widthdraw(string bank, long amount)
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
                base.Widthdraw(bank, amount);
                Balance -= 1100; // trừ phí rút tiền
                var fee = (long)(1.0 / 100 * amount); // phí 1%
                Balance -= fee;
                return amount + 1100 + fee;
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
