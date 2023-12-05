namespace lý_thuyết_đồ_thị
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("TÌM HIỂU VỀ LÝ THUYẾT ĐỒ THỊ ");
            Console.WriteLine("Dưới dây là 13 khái niệm về lý thuyết đồ thị , vui lòng chọn con số để xem lý thuyết : ");
            Console.WriteLine("1.Đơn đồ thị vô hướng.");
            Console.WriteLine("2.Đa đồ thị vô hướng ");
            Console.WriteLine("3.Giả đồ thị vô hướng ");
            Console.WriteLine("4.Đơn đồ thị có hướng.");
            Console.WriteLine("5.Đa đồ thị có hướng ");
            Console.WriteLine("6.Đỉnh kề , cạnh liên thuộc ");
            Console.WriteLine("7.Bậc của đồ thị vô hướng ");
            Console.WriteLine("8.Bán bậc vào , bán bậc ra ");
            Console.WriteLine("9.Đường đi ");
            Console.WriteLine("10.Chu trình ");
            Console.WriteLine("11.Liên thông ");
            Console.WriteLine("12.Thành phần liên thông ");
            Console.WriteLine("13.Liên thông mạnh , liên thông yếu ");
            Console.Write("Nhập con số muốn xem khái niệm ");
            int output;
            string n = Console.ReadLine();
            if (int.TryParse(n,out output) && output >= 1 && output <= 13)
            {
                DisplayConcept(output);
            }
            else
            {
                Console.WriteLine("ko có số đó vui lòng nhập lại ");
            }
        }
        static void DisplayConcept(int output)
        {
            switch (output)
            {
                case 1:
                    Console.WriteLine("Đơn đồ thị vô hướng: Đồ thị không hướng, không có chiều.");
                    break;
                case 2:
                    Console.WriteLine("Đa đồ thị vô hướng: Đồ thị có thể có nhiều cạnh giữa các đỉnh.");
                    break;
                case 3:
                    Console.WriteLine("Giả đồ thị vô hướng: Đồ thị không có vòng (cycle), có khuyên ");
                    break;
                case 4:
                    Console.WriteLine("Đơn đồ thị có hướng: Đồ thị có hướng từ một đỉnh đến một đỉnh khác.");
                    break;
                case 5:
                    Console.WriteLine("Đa đồ thị có hướng: Đồ thị có thể có nhiều cạnh hướng giữa các đỉnh.");
                    break;
                case 6:
                    Console.WriteLine("Đỉnh kề, cạnh liên thuộc: Đỉnh kề là các đỉnh được nối bằng cạnh.");
                    break;
                case 7:
                    Console.WriteLine("Bậc của đồ thị vô hướng: Bậc của một đỉnh là số cạnh kề với nó.");
                    break;
                case 8:
                    Console.WriteLine("Bán bậc vào, bán bậc ra: Bán bậc vào là số cạnh đi vào một đỉnh, bán bậc ra là số cạnh đi ra từ một đỉnh.");
                    break;
                case 9:
                    Console.WriteLine("Đường đi: Dãy đỉnh liên tiếp nhau qua các cạnh, không qua đỉnh nào lặp lại.");
                    break;
                case 10:
                    Console.WriteLine("Chu trình: Đường đi tạo thành một vòng, bắt đầu và kết thúc ở cùng một đỉnh.");
                    break;
                case 11:
                    Console.WriteLine("Liên thông: Mọi cặp đỉnh đều có đường đi giữa chúng.");
                    break;
                case 12:
                    Console.WriteLine("Thành phần liên thông: Một tập hợp các đỉnh mà giữa chúng có đường đi.");
                    break;
                case 13:
                    Console.WriteLine("Liên thông mạnh, liên thông yếu: Liên thông mạnh đồng nghĩa với mỗi cặp đỉnh đều có đường đi cả hai chiều giữa chúng.");
                    Console.WriteLine("Liên thông yếu đồng nghĩa với có ít nhất một chiều có đường đi giữa mỗi cặp đỉnh.");
                    break;
                default:
                    Console.WriteLine("Không có khái niệm cho số này.");
                    break;
            }
        }

    }
}