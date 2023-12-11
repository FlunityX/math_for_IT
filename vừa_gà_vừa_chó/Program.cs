using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace vừa_gà_vừa_chó
{
    /*Vừa gà vừa chó

    Bó lại cho tròn

    Ba mươi sáu con

   Một trăm chân chẵn

     Một câu đố dân gian nổi tiếng chắc hẳn tất cả các bạn đều biết.Và bạn có thể cũng đã biết đáp án của câu đố trên là
    22 con gà và 14 con chó.Tuy nhiên, thầy giáo của Hiếu lại bắt anh ấy phải giải bài tập tổng quát: "Tìm số gà, số chó khi
    số tổng số con là m và số chân là n
    nếu m và n khiến số gà số chó ko phù hợp in -1
. Bạn hãy giúp Hiếu giải bài toán này nhé.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap tong so con");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so chan ");
            int n =int.Parse(Console.ReadLine());
            tinhsocon(n, m);
            Console.ReadLine();
        }
        static void  tinhsocon(int m , int n)
        {
            int soga;
            int socho;
            // số gà chạy từ 0 đến m số chó = m - số gà , nếu thảo mãn thêm điều kiện  if (4 * socho + 2 * soga == n) thì in ra so gà chó
            for (soga = 0; soga <= m; soga++)
            {
                socho = m - soga;
                if (4 * socho + 2 * soga == n)
                {
                    Console.WriteLine("Số lượng gà: " + soga);
                    Console.WriteLine("Số lượng chó: " + socho);
                    return;
                }
            }
            Console.WriteLine("-1");

        }
    }
}
