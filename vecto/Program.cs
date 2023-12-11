using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vecto
{

    internal class Program
    {
        //Cho m điểm phân biệt trên mặt phẳng, hỏi có bao nhiêu véc tơ khác véc tơ-không mà điểm đầu và điểm cuối là
        //hai điểm trong số điểm trên?
        //Số lượng véc-tơ khác véc-tơ không = n * (n - 1)
        static void Main(string[] args)
        {
            Console.WriteLine("nhap m diem : ");
            int m = int.Parse(Console.ReadLine());
            int sum = m * (m - 1);
            Console.WriteLine("So lg vecto la :"+sum);
            Console.ReadLine();
        }
    }
}
