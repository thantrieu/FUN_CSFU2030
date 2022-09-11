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
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
                if(choice == 7)
                {
                    break;
                }
            }
        }
    }

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
