using System;
using System.Text;

namespace Chapter8
{
    class Lesson87
    {
        static void Main()
        {
            // cho hiển thị tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            var dateFormat = "dd/MM/yyyy"; // định dạng ngày tháng
            var timeFormat = "HH:mm:ss"; // định dạng giờ
            var dateTimeFormat = "MMMM dd, yyyy HH:mm:ss"; // cả ngày giờ
            var format = "dd-MM-yyy hh:mm:ss tt"; // cả ngày và giờ
            // các string chứa thời gian cần chuyển sang đối tượng date time
            var dateString = "27/04/2009";
            var fullDateTimeString = "January 16, 2025 15:34:26";

            DateTime now = DateTime.Now; // lấy ngày giờ hiện tại
            Console.WriteLine($"Giờ hiện tại: {now.ToString(timeFormat)}"); // lấy phần giờ của đối tượng
            Console.WriteLine($"Ngày hiện tại: {now.ToString(dateFormat)}"); // lấy phần ngày
            Console.WriteLine($"Ngày và giờ hiện tại: {now.ToString(dateTimeFormat)}"); // định dạng theo yêu cầu
            Console.WriteLine($"Ngày và giờ hiện tại: {now.ToString(format)}"); // định dạng theo yêu cầu

            // chuyển đổi string sang đối tượng DateTime với định dạng cho trước
            DateTime birthDate = DateTime.ParseExact(dateString, dateFormat, null);
            Console.WriteLine("Sinh nhật của tôi: " + birthDate.ToString(dateFormat));

            var otherDateTime = DateTime.ParseExact(fullDateTimeString, dateTimeFormat, null);
            Console.WriteLine("Ngày đầy đủ: " + otherDateTime.ToLongDateString());
            Console.WriteLine("Ngày giờ tự định dạng: " + otherDateTime.ToString(dateTimeFormat));
            Console.WriteLine("Ngày tự định dạng: " + otherDateTime.ToString(dateFormat));
            Console.WriteLine("Giờ tự định dạng: " + otherDateTime.ToString(timeFormat));
        }
    }
}
