using System.Security.Cryptography.X509Certificates;

namespace đạo_hàm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  TINH DAO HAM   ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. dao ham cua 1 hang so : y = (k.x)' :");
            Console.WriteLine("2. dao ham y = (x^n)' ");
            Console.WriteLine("3. dao ham y = (can x)' ");
            Console.WriteLine("4. dao ham y = (1/x)'");
            Console.WriteLine("nhap lua chon cua ban :");
            if (int.TryParse(Console.ReadLine(), out int chon))
            {
                TinhDaoHam(chon);
            }
            else
            {
                Console.WriteLine("Nhap khong hop le. Hay nhap mot so nguyen.");
            }
            Console.ReadLine();
        }
        public static void TinhDaoHam(int chon)
        {
            switch (chon)
            {
                case 1:
                    Console.WriteLine("dao ham la y = x");
                    Console.WriteLine("nhap gia tri x : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("gia tri y = {0} ", a);
                    break;
                case 2:
                    Console.WriteLine("nhap co so (x) :");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("nhap so mu (n) :");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("dao ham la y = {0}.x^({1}) ", b, b - 1);
                    double d = c * Math.Pow(b, c - 1);
                    Console.WriteLine("gia tri y = {0}", d);
                    break;
                case 3:
                    Console.WriteLine("dao ham la : y = 1/ 2 can x ");
                    Console.WriteLine("nhap co so x :");
                    int f = int.Parse(Console.ReadLine());
                    double daoham4 = 1 / (double)2 * Math.Sqrt(f);
                    Console.WriteLine(" gia tri y la : {0} ", daoham4);
                    break;

                case 4:
                    Console.WriteLine("dao ham la y = -1/x^2 ");
                    Console.WriteLine("nhap co so (x) :");
                    int e = int.Parse(Console.ReadLine());
                    double daoham3 = -1 / (double)Math.Pow(e, 2);
                    Console.WriteLine("gia tri y = {0} ", daoham3);
                    break;
                
                default:
                    return;
                    
            }
        }
    }
}