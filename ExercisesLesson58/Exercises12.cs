///<resultmary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.09.11</version>
///</resultmary>

using System;
using System.Text;

namespace ExercisesLesson58
{
    class Exercises12
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            BankAcc[] accounts = new BankAcc[100];
            int size = 0;
            while (true)
            {
                Console.WriteLine("============= MENU =============");
                Console.WriteLine("1. Tạo mới tài khoản.");
                Console.WriteLine("2. Nạp tiền vào tài khoản.");
                Console.WriteLine("3. Truy vấn số dư tài khoản.");
                Console.WriteLine("4. Rút tiền từ tài khoản.");
                Console.WriteLine("5. Chuyển tiền khỏi tài khoản.");
                Console.WriteLine("6. Hiển thị danh sách tài khoản.");
                Console.WriteLine("7. Kết thúc chương trình.");
                Console.WriteLine("Xin mời chọn: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        accounts[size++] = CreateAccount();
                        break;
                    case 2:
                        Deposit(accounts);
                        break;
                    case 3:
                        CheckBallance(accounts);
                        break;
                    case 4:
                        WithDraw(accounts);
                        break;
                    case 5:
                        BankTransfer(accounts);
                        break;
                    case 6:
                        if (size == 0)
                        {
                            Console.WriteLine("==> Danh sách tài khoản rỗng. <==");
                        }
                        else
                        {
                            var accNumber = "Số TK";
                            var balance = "Số dư";
                            var status = "Trạng thái";
                            var fee = "Phí duy trì";
                            Console.WriteLine($"{accNumber,-15}{balance,-15}{status,-20}{fee,-15}");
                            foreach (var acc in accounts)
                            {
                                if (acc.AccNumber != null && acc.AccNumber != "")
                                {
                                    ShowAccount(acc);
                                }
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("==> Chương trình kết thúc. <==");
                        break;
                    default:
                        Console.WriteLine("Sai chức năng. Vui lòng chọn chức năng từ 1-7.");
                        break;
                }
                if (choice == 7)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Phương thức chuyển tiền từ tài khoản A -> B.
        /// </summary>
        /// <param name="accounts">Danh sách tài khoản hiện có.</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void BankTransfer(BankAcc[] accounts)
        {
            Console.WriteLine("Số tài khoản nguồn: ");
            var srcNumber = Console.ReadLine();
            Console.WriteLine("Số tài khoản đích: ");
            var destNumber = Console.ReadLine();
            Console.WriteLine("Số tiền cần chuyển: ");
            var amount = int.Parse(Console.ReadLine());
            var srcIndex = FindAccountIndex(accounts, srcNumber);
            var destIndex = FindAccountIndex(accounts, destNumber);
            if (srcIndex != -1 && destIndex != -1)
            {
                if (amount < 0)
                {
                    Console.WriteLine("==> Số tiền cần chuyển không hợp lệ. <==");
                }
                else if (amount <= accounts[srcIndex].Balance - accounts[srcIndex].MaintenanceFee)
                {
                    Console.WriteLine("==> Số tiền cần chuyển vượt quá số dư hiện tại.");
                }
                else if (accounts[srcIndex].Status.CompareTo("Active") == 0
                    && accounts[destIndex].Status.CompareTo("Active") == 0)
                {
                    accounts[srcIndex].Balance -= amount;
                    accounts[destIndex].Balance += amount;
                    Console.WriteLine($"==> TK {srcNumber}: -{amount:N0}đ.");
                    Console.WriteLine($"==> TK {destNumber}: +{amount:N0}đ.");
                    Console.WriteLine("==> Chuyển tiền thành công! <==");
                }
                else
                {
                    Console.WriteLine("==> Tài khoản nguồn hoặc tài khoản đích đang bị vô hiệu hóa! <==");
                }
            }
            else
            {
                Console.WriteLine("==> Tài khoản đích hoặc tài khoản nguồn không đúng! <==");
            }
        }

        /// <summary>
        /// Phương thức dùng để kiểm tra xem tài khoản cần tìm có tồn tại không
        /// </summary>
        /// <param name="accounts"></param>
        /// <param name="accNumber"></param>
        /// <returns>Giá trị >= 0 nếu tìm thấy. Trả về -1 nếu không tìm thấy.</returns>
        private static int FindAccountIndex(BankAcc[] accounts, string accNumber)
        {
            int index = 0;
            foreach (var item in accounts)
            {
                if (item.AccNumber != null)
                {
                    if (item.AccNumber.CompareTo(accNumber) == 0)
                    {
                        return index;
                    }
                }
                index++;
            }
            return -1;
        }

        /// <summary>
        /// Phương thức thể hiện việc nộp tiền vào tài khoản
        /// </summary>
        /// <param name="accounts">Danh sách tài khoản hiện có</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void Deposit(BankAcc[] accounts)
        {
            Console.WriteLine("Số tài khoản: ");
            var accNumber = Console.ReadLine();
            Console.WriteLine("Số tiền cần nạp: ");
            var amount = int.Parse(Console.ReadLine());
            var accIndex = FindAccountIndex(accounts, accNumber);
            if (accIndex == -1)
            {
                Console.WriteLine("==> Tài khoản cần tìm không tồn tại! <==");
            }
            else
            {
                if (amount < 0 || amount > accounts[accIndex].Balance - accounts[accIndex].MaintenanceFee)
                {
                    Console.WriteLine("==> Số tiền cần rút không hợp lệ! <==");
                }
                else if (accounts[accIndex].Status.CompareTo("Active") == 0)
                {
                    accounts[accIndex].Balance += amount;
                    Console.WriteLine($"==> Số tài khoản: {accNumber}: +{amount:N0}đ");
                    Console.WriteLine("==> Nạp tiền thành công! <==");
                }
                else
                {
                    Console.WriteLine("==> Tài khoản này đang bị vô hiệu hóa! <==");
                }
            }
        }

        /// <summary>
        /// Phương thức kiểm tra số dư và thông tin tài khoản.
        /// </summary>
        /// <param name="accounts">Danh sách tài khoản hiện tại.</param>
        private static void CheckBallance(BankAcc[] accounts)
        {
            Console.WriteLine("Số tài khoản: ");
            var accNumber = Console.ReadLine();
            var accIndex = FindAccountIndex(accounts, accNumber);
            if (accIndex == -1)
            {
                Console.WriteLine("==> Tài khoản cần tìm không tồn tại! <==");
            }
            else
            {
                Console.WriteLine("==> Thông tin tài khoản: ");
                Console.WriteLine($"==> Số tài khoản: {accounts[accIndex].AccNumber}");
                Console.WriteLine($"==> Số Số dư: +{accounts[accIndex].Balance:N0}đ");
                Console.WriteLine($"==> Trạng thái tài khoản: {accounts[accIndex].Status}");
            }
        }

        /// <summary>
        /// Phương thức rút tiền khỏi tài khoản
        /// </summary>
        /// <param name="accounts">Danh sách tài khoản hiện có.</param>
        private static void WithDraw(BankAcc[] accounts)
        {
            Console.WriteLine("Số tài khoản: ");
            var accNumber = Console.ReadLine();
            Console.WriteLine("Số tiền cần rút: ");
            var amount = int.Parse(Console.ReadLine());
            var accIndex = FindAccountIndex(accounts, accNumber);
            if (accIndex == -1)
            {
                Console.WriteLine("==> Tài khoản cần tìm không tồn tại! <==");
            }
            else
            {
                if (amount < 0 || amount > accounts[accIndex].Balance - accounts[accIndex].MaintenanceFee)
                {
                    Console.WriteLine("==> Số tiền cần rút không hợp lệ! <==");
                }
                else if (accounts[accIndex].Status.CompareTo("Active") == 0)
                {
                    accounts[accIndex].Balance -= amount;
                    Console.WriteLine($"==> Số tài khoản: {accNumber}: -{amount:N0}đ");
                    Console.WriteLine("==> Rút tiền thành công! <==");
                }
                else
                {
                    Console.WriteLine("==> Tài khoản này đang bị vô hiệu hóa! <==");
                }
            }
        }

        /// <summary>
        /// Phương thức hiển thị thông tin tài khoản.
        /// </summary>
        /// <param name="acc">Tài khoản cần hiển thị thông tin</param>
        private static void ShowAccount(BankAcc acc)
        {
            Console.WriteLine($"{acc.AccNumber,-15}{acc.Balance,-15}" +
                $"{acc.Status,-20}{acc.MaintenanceFee,-15}");
        }

        /// <summary>
        /// Phương thức tạo mới thông tin tài khoản.
        /// </summary>
        /// <returns>Tài khoản mới sau khi tạo.</returns>
        private static BankAcc CreateAccount()
        {
            Console.WriteLine("Số tài khoản: ");
            var accNumber = Console.ReadLine();
            Console.WriteLine("Số dư: ");
            var balance = long.Parse(Console.ReadLine());
            Console.WriteLine("Phí duy trì thẻ: ");
            int fee = int.Parse(Console.ReadLine());
            var status = "Active";
            return new BankAcc(accNumber, balance, status, fee);
        }
    }

    /// <summary>
    /// struct mô tả thông tin tài khoản ngân hàng.
    /// </summary>
    public struct BankAcc
    {
        public string AccNumber { get; set; }
        public long Balance { get; set; }
        public string Status { get; set; }
        public int MaintenanceFee { get; set; }

        public BankAcc(string accNumber = "", long balance = 0, string status = "", int fee = 0)
        {
            AccNumber = accNumber;
            Balance = balance;
            Status = status;
            MaintenanceFee = fee;
        }
    }
}
