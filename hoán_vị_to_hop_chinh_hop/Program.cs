using System;

namespace hoan_vị_to_hop_chinh_hop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap hoan vi cua so n :");
            int a = int.Parse(Console.ReadLine());
            int sohoanviA = hoanviA(a);

            Console.WriteLine("nhap to hop n chập k - C(k,n) - nhap n :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap to hop n chập k - C(k,n) - nhap k :");
            int k = int.Parse(Console.ReadLine());
            int sohoanvin = hoanviN(n);
            int sohoanvik = hoanviN(k);
            int sohoanviNtruK = hoanviN(n - k);
            double tohop = tinhtohop(sohoanvin, sohoanvik, sohoanviNtruK);

            Console.WriteLine("nhap chinh hop n chập k - P(k,n) - nhap n :");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap chinh hop n chập k - P(k,n) - nhap k :");
            int d = int.Parse(Console.ReadLine());
            double sochinhhop = tinhtochinhhop(sohoanvin, sohoanviNtruK);

            Console.WriteLine("hoan vi cua so n la: " + sohoanviA);
            Console.WriteLine("nhap to hop n chập k - C({0},{1}): {2}", k, n, tohop);
            Console.WriteLine("nhap chinh hop n chập k - P({0},{1}): {2}", d, c, sochinhhop);

            Console.ReadLine();
        }

        static int hoanviN(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * hoanviN(n - 1);
        }

        static int hoanviA(int a)
        {
            if (a <= 1)
            {
                return 1;
            }
            return a * hoanviA(a - 1);
        }

        static double tinhtohop(int sohoanvin, int sohoanvik, int sohoanviNtruK)
        {
            return (double)sohoanvin / (sohoanvik * sohoanviNtruK);
        }

        static double tinhtochinhhop(int sohoanvin, int sohoanviNtruK)
        {
            return sohoanvin / sohoanviNtruK;
        }
    }
}