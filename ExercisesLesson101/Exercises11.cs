/// <summary>
/// <author>Branium Academy</author>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// <version>2022.06.07</version>
/// </summary>
///

using System;
using System.Text;

namespace ExercisesLesson101
{
    internal class Exercises11
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cart<string, int> cart = new Cart<string, int>("Macbook Pro 16' 2025", 3);
            cart.SubTotal = 150000000;
            cart.DiscountRate = 15;
            cart.Total = cart.SubTotal * (1 - cart.DiscountRate / 100);

            Console.WriteLine("==> Thông tin giỏ hàng: ");
            Console.WriteLine($"Mặt hàng: {cart.Item}");
            Console.WriteLine($"Số lượng: {cart.Quantity} chiếc");
            Console.WriteLine($"Thành tiền: {cart.SubTotal:N0}đ");
            Console.WriteLine($"Chiết khấu: {cart.DiscountRate}%");
            Console.WriteLine($"Tổng tiền phải thanh toán: {cart.Total:N0}đ");
        }
    }

    class Cart<TKey, TValue>
    {
        public TKey Item { get; set; }
        public TValue Quantity { get; set; }
        public float DiscountRate { get; set; }
        public float SubTotal { get; set; }
        public float Total { get; set; }

        public Cart()
        {
        }

        public Cart(TKey item, TValue quantity)
        {
            Item = item;
            Quantity = quantity;
        }

        public Cart(TKey item, TValue quantity, float discountRate, float subTotal, float total)
        {
            Item = item;
            Quantity = quantity;
            DiscountRate = discountRate;
            SubTotal = subTotal;
            Total = total;
        }
    }
}
